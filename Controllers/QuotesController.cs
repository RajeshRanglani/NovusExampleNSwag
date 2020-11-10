using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NovusExampleNSwag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {

        [HttpHead("{id}", Name = "QuoteByIdHEAD")]
        #region ProducesResponseType
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status304NotModified)]
        [ProducesResponseType(StatusCodes.Status307TemporaryRedirect)]
        [ProducesResponseType(StatusCodes.Status308PermanentRedirect)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        #endregion
        [Produces("application/json")]
        public async Task<IActionResult> Head([FromRoute] string id)
        {
            try
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost()]
        #region ProducesResponseType
        [ProducesResponseType(typeof(Quote), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Quote), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status307TemporaryRedirect)]
        [ProducesResponseType(StatusCodes.Status308PermanentRedirect)]
        [ProducesResponseType(429)] //Too Many Requests
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        #endregion
        [Produces("application/json", "application/xml")]
        [Consumes("application/json", "application/xml")]

        public async Task<IActionResult> Post([FromBody]QuoteCreate quote)
        {
            try
            {

                var id = Guid.NewGuid();
                var viewModel = quote;
                return CreatedAtAction("Get", new { id = id }, viewModel);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        #region ProducesResponseType
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status307TemporaryRedirect)]
        [ProducesResponseType(StatusCodes.Status308PermanentRedirect)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        #endregion
        [Produces("application/json", "application/xml")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            try
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}