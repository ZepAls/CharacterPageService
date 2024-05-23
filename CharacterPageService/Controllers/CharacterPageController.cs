using BLL;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace CharacterPageService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class CharacterPageController : ControllerBase
    {
        // GET: api/<CharacterPageController>
        [HttpGet]
        public ActionResult Get()
        {
            CharacterPageHandler handler = new CharacterPageHandler();
            IEnumerable<CharacterPageDTO> characterPagelist = handler.GetAllCharacterPages();
            if (characterPagelist.Count() != 0)
            {
                return Ok(characterPagelist);
            }
            return NotFound("There are no CharacterPages found");
        }

        // GET api/<CharacterPageController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            CharacterPageHandler handler = new CharacterPageHandler();
            CharacterPageDTO returnCharacterPage = handler.GetCharacterPage(id);
            if (returnCharacterPage != null)
            {
                return Ok(returnCharacterPage);
            }
            return NotFound($"CharacterPage could not be found: There is no CharacterPage with id : {id}");
        }

        // POST api/<CharacterPageController>
        [HttpPost]
        public ActionResult Post(CharacterPageDTO characterPage)
        {
            if (characterPage.Id == 0)
            {
                CharacterPageHandler handler = new CharacterPageHandler();
                handler.CreateCharacterPage(characterPage);
                return Ok("CharacterPage created succesfully");
            }
            return BadRequest($"CharacterPage could not be created: Id was expected to be 0 but was {characterPage.Id}");
        }

        // PUT api/<CharacterPageController>/5
        [HttpPut]
        public ActionResult Put(CharacterPageDTO characterPage)
        {
            CharacterPageHandler handler = new CharacterPageHandler();
            if (handler.GetCharacterPage(characterPage.Id) != null)
            {
                handler.UpdateCharacterPage(characterPage);
                return Ok("CharacterPage updated succesfully");
            }
            return BadRequest($"CharacterPage could not be updated: There is no CharacterPage with id {characterPage.Id}");

        }

        // DELETE api/<CharacterPageController>/5
        [HttpDelete]
        public ActionResult Delete(CharacterPageDTO characterPage)
        {
            CharacterPageHandler handler = new CharacterPageHandler();
            if (handler.GetCharacterPage(characterPage.Id) != null)
            {
                handler.DeleteCharacterPage(characterPage);
                return Ok("CharacterPage Deleted succesfully");
            }
            return BadRequest($"CharacterPage could not be deleted: There is no CharacterPage with id {characterPage.Id}");
        }
    }

}

