using Microsoft.AspNetCore.Http;
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
    
        //GET: api/QAlloted
        [HttpGet("{trainingID}/{questionTypeID}")]
        public async Task<int[]> GetAllotedQuestionIDs(int? trainingID, int? questionTypeID)
        {
            try
            {
                var list = await config.Qalloteds.Where(t => t.TrainingId == trainingID)
                                                    .Where(q => q.QuestionTypeId == questionTypeID).ToListAsync();

                int counter = 0;
                int? questionCount = list[0].Alloted;
                int[] selectedQuestions = new int[(int)questionCount];

                int?[] res = new int?[list.Count()];

                if (list.Count() > 0)
                {
                    for (int i = 0; i <= list.Count() - 1; i++)
                    {
                        res[i] = list[i].QuestionId;
                    }
                }

                var min = res.Min();
                var max = res.Max();

                Random r = new Random();

                //getting questions in a random fashion
                while(counter < (int)questionCount)
                {
                    var generatedQuestionNo = r.Next((int)min, (int)max);

                    //check if the question no exists in the original questions pulled up
                    if ((!selectedQuestions.Contains(generatedQuestionNo)) && (res.Contains(generatedQuestionNo)))
                    {
                        selectedQuestions[counter] = generatedQuestionNo;
                        counter++;
                    }
                }

                return selectedQuestions;
            }
            catch(Exception xx)
            {
                return null;
            }
            
        }
    }
}
