/*
 * Stundenplan - OpenAPI 3.0
 *
 * Dieses Dokument stellt die Backend-API des Stundenplan Tools dar. Es ermöglicht den einfachen Zugriff vom Frontend auf die notwendigen entitäten um die Funktionalität des Stundenplan Tools zu verwenden. Weiter können dieselben Informationen auch für Drittanwendungen verwendet werden.
 *
 * OpenAPI spec version: 1.0.11
 * Contact: angelo.conconi@stud.hslu.ch
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class StundenplanApiController : ControllerBase
    { 
        /// <summary>
        /// Löschen
        /// </summary>
        /// <remarks>löscht eine Klasse</remarks>
        /// <param name="classID"></param>
        /// <response code="400">Invalid Class ID</response>
        [HttpDelete]
        [Route("//Stundenplan")]
        [ValidateModelState]
        [SwaggerOperation("StundenplanDelete")]
        public virtual IActionResult StundenplanDelete([FromHeader]string classID)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Abfragen
        /// </summary>
        /// <remarks>Um eine bestehende Klasse aus der Datenbank zu erhalten muss die entsprechende ID mitgeliefert werden</remarks>
        /// <response code="200">Successful operation</response>
        [HttpGet]
        [Route("//Stundenplan")]
        [ValidateModelState]
        [SwaggerOperation("StundenplanGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClass), description: "Successful operation")]
        public virtual IActionResult StundenplanGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClass));
            string exampleJson = null;
            exampleJson = "{\n  \"endDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"description\" : \"198772\",\n  \"students\" : \"angelo.conconi@stud.hslu.ch\",\n  \"id\" : 10,\n  \"startDate\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelClass>(exampleJson)
                        : default(ModelClass);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Erstellen
        /// </summary>
        /// <remarks>Erstellt eine neue Klasse in der Datenbank</remarks>
        /// <param name="body"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("//Stundenplan")]
        [ValidateModelState]
        [SwaggerOperation("StundenplanPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClass), description: "Successful operation")]
        public virtual IActionResult StundenplanPost([FromBody]ModelClass body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClass));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"endDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"description\" : \"198772\",\n  \"students\" : \"angelo.conconi@stud.hslu.ch\",\n  \"id\" : 10,\n  \"startDate\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelClass>(exampleJson)
                        : default(ModelClass);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Aktualisieren
        /// </summary>
        /// <remarks>Um eine bestehnde Klasse zu aktualisieren muss die entsprechende ID mitgeliefert werden</remarks>
        /// <param name="body">Update einer existierenden Klasse in der Schule</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Class not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("//Stundenplan")]
        [ValidateModelState]
        [SwaggerOperation("StundenplanPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClass), description: "Successful operation")]
        public virtual IActionResult StundenplanPut([FromBody]ModelClass body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClass));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"endDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"description\" : \"198772\",\n  \"students\" : \"angelo.conconi@stud.hslu.ch\",\n  \"id\" : 10,\n  \"startDate\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelClass>(exampleJson)
                        : default(ModelClass);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}