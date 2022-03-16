﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;
using PETAS.Models.Domain;
using PETAS.Models.Domain.HRMS;
using PETAS.Data.Data;

namespace PETAS.Services
{
    public interface IDragService
    {
        public Task<bool> AssignTrainingAsync(string source, Training t, object _Data);
    }

    public class DragService: IDragService, IHRMSService
    {
        private readonly HttpClient http;
        private readonly HRMSClient hrmsClient;
        public DragService(HRMSClient _hrmsclient)
        {
            http = _hrmsclient.http;
        }

        public async Task<bool> AssignTrainingAsync(string source, Training t, object _Data)
        {
<<<<<<< HEAD
            
            var employeeData = await GetTraineeList(_Data);

            //get the employee data, persist record and notifiy employees of the training programme
=======
            HRMSContext _context = new HRMSContext();
            var obj = new DragHelper(_context) { 
                Source = source,
                Target = t,
                Data = _Data
            };

            var employeeData = await obj.GetTraineeList();

            //send the data to the api for mail sending
>>>>>>> 58570de38b21f84fbd50354a8535d031d37fa97a
            return true;
        }

        #region Private Methods

        private async Task<List<Employee>> GetTraineeList(object Data)
        {
            //gets the name and email address for the object in question
            var type = Data.GetType().Name;
            if (type == @"Department")
            {
                return await ByDepartment((Department)Data);
            }
            else if (type == @"Group")
            {
                return await ByGroup((Group)Data);
            }
            else if (type == @"Grade")
            {
                return await ByGrade((Grade)Data);
            }
            else
            {
                //JobTitle
                return await ByJobTitle((JobTitle)Data);
            }
        }

        private async Task<List<Employee>> ByDepartment(Department obj)
        {
            //gets the list of employees, especially their email addresses
            try
            {
                return await http.GetFromJsonAsync<List<Employee>>("api/Employees/ByDepartment" + "/" + obj.DepartmentId);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                throw ex;
            }
        }

        private async Task<List<Employee>> ByGrade(Grade obj)
        {
            //gets the list of employees, especially their email addresses
            try
            {
                return await http.GetFromJsonAsync<List<Employee>>("api/Employees/ByGrade" + "/" + obj.GradeId);
            }
            catch (Exception x)
            {
                Debug.Print(x.Message);
                throw x;
            }
        }

        private async Task<List<Employee>> ByGroup(Group obj)
        {
            try
            {
                return await http.GetFromJsonAsync<List<Employee>>("api/Employees/ByGroup" + "/" + obj.GroupId);
            }
            catch (Exception x)
            {
                Debug.Print(x.Message);
                throw x;
            }
        }

        private async Task<List<Employee>> ByJobTitle(JobTitle obj)
        {
            try
            {
                return await http.GetFromJsonAsync<List<Employee>>("api/Employees/ByJobTitle" + "/" + obj.JobTitleId);
            }
            catch (Exception x)
            {
                Debug.Print(x.Message);
                throw x;
            }
        }


        #endregion

        #region IHRMSService interface implementations

        public async Task<List<Department>> GetDepartmentsAsync() { return new List<Department>(); }
        public async Task<List<Employee>> GetEmployeeAsync() { return new List<Employee>(); }
        public async Task<List<Grade>> GetGradeAsync() { return new List<Grade>(); }
        public async Task<List<Group>> GetGroupAsync() { return new List<Group>(); }
        public async Task<List<JobTitle>> GetJobTitlesAsync() { return new List<JobTitle>(); }

        #endregion

    }

}
