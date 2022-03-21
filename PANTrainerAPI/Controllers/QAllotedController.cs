﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PETAS.Data.Data;
using PETAS.Models.Domain;

namespace PANTrainerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QAllotedController : ControllerBase
    {
        private readonly PantrainerContext config;

        public QAllotedController(PantrainerContext _context)
        {
            config = _context;
        }

        //GET: api/QAlloted
        [HttpGet("{id}")]
        public async Task<ActionResult<Qalloted>> GetQAlloted(int id)
        {
            var obj = await config.Qalloteds.FindAsync(id);
            if (obj == null)
            {
                return NotFound();
            }

            return obj;
        }

        //POST: api/QAlloted
        [HttpPost]
        public async Task<ActionResult<Qalloted>> PostAllotedQuestion(JObject data)
        {
            if (data == null)
            {
                return BadRequest();
            }

            var oTraining = data["trainingObj"].ToObject<Training>();
            var oTAssessment = data["tAssessment"].ToObject<TrainingAssessment>();
            var oQuestions = data["question"].ToObject<AssessmentQuestionPool>();
            var questionTypeID = int.Parse(data["qTypeID"].ToString());

            var obj = new Qalloted
            {
                TrainingId = oTraining.Id,
                TrainingAssessmentId = oTAssessment.Id,
                QuestionId = oQuestions.Id,
                QuestionTypeId = questionTypeID,
                Alloted = oTAssessment.AllotedAssessmentMarks
            };

            config.Qalloteds.Add(obj);
            await config.SaveChangesAsync();

            return CreatedAtAction("GetQAlloted", new { id = obj.Id }, obj);
        }
    }
}