using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;

using PETAS.Models.Domain;

namespace PETAS.Services
{
    public interface IQAllotedService
    {
        public Task<string> SaveAllotedQuestionsAsync(Training trainingObj, TrainingAssessment tAssessment, List<AssessmentQuestionPool> questions, int qTypeID);
    }

    public class QAllotedService: IQAllotedService
    {
        private readonly HttpClient http;

        public QAllotedService(HttpClient _httpClient)
        {
            http = _httpClient;
        }

        public async Task<string> SaveAllotedQuestionsAsync(Training trainingObj, TrainingAssessment tAssessment, List<AssessmentQuestionPool> questions, int qTypeID)
        {
            int success = 0;
            int failed = 0;

            try
            {
                foreach(var question in questions)
                {
                    try
                    {
                        var postBody = new { trainingObj, tAssessment, question, qTypeID };

                        var result = await http.PostAsJsonAsync("api/QAlloted", postBody);
                        var obj = result.Content.ReadFromJsonAsync<Qalloted>();
                        if (obj.Id > 0)
                        {
                            success += 1;
                        }
                        else { failed += 1; }
                    }
                    catch(Exception xx)
                    {
                        Debug.Print($"error: {xx.Message}");
                        failed += 1;
                    }
                }

                return $"Total questions: {questions.Count().ToString()}, successful inserts: {success.ToString()}, failed inserts: {failed.ToString()}";
            }
            catch(Exception ex)
            {
                return $"error: {ex.Message}";
            }
        }

    }
}
