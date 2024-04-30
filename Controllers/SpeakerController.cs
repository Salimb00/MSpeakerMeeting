using Moq;
using Microsoft.AspNetCore.Mvc;
using SpeakerService.Interfaces;

namespace MSpeakerMeeting.API.Controllers
{
    public class SpeakerController
    {
    }
}

namespace MSpeakerMeeting.API
{
    [Route("api/[controller]")]
    public class SpeakerController:Controller
    {
        Mock<ISpeakerService> _speakerServiceMock;

        public SpeakerController(Mock<ISpeakerService> speakerServiceMock)
        {
            _speakerServiceMock=speakerServiceMock;
        }

        public IActionResult GetAll()
        {
            _speakerServiceMock.Object.GetSummaries();
            return Ok(new List<SpeakerSummary>());
        }

    }
}