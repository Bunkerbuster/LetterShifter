using LetterShifterService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LetterShifter.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShifterController : ControllerBase
    {

        private readonly ITranslateString _ITranslateString;

        public ShifterController(ITranslateString _Itranslatestring)
        {
            _ITranslateString = _Itranslatestring;  
        }



        [HttpGet("/{_Input}/{_Reverse}")]
        public async Task<ActionResult> GetAsync( string _Input, int _Reverse = 1)
        {
            return Ok(_ITranslateString.Translate(_Input, _Reverse));
        }
    }
}
