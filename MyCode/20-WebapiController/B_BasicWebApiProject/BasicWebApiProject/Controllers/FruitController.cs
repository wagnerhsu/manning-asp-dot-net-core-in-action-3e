using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebApiProject.Controllers;

[ApiController]
public class FruitController : ControllerBase
{
    private readonly FruitService _fruitService;
    private readonly ILogger<FruitController> _logger;

    public FruitController(FruitService fruitService, ILogger<FruitController> logger)
    {
        _fruitService = fruitService;
        _logger = logger;
    }

    [HttpGet("fruit")]
    public IEnumerable<string> Index()
    {
        return _fruitService.Fruit;
    }

    [HttpGet("fruit/{id}")]
    public ActionResult<string> View(int id)
    {
        if (id >= 0 && id < _fruitService.Fruit.Count)
        {
            return _fruitService.Fruit[id];
        }

        return NotFound();
    }

    [HttpPost("PostStringData")]
    public ActionResult<string> PostStringData([Required] string stringData)
    {
        _logger.LogDebug("stringData:"+stringData);
        return Ok(stringData);
    }
    [HttpPost("PostJsonData")]
    public ActionResult<string> PostJsonData([Required] JsonObject jsonObject)
    {
        var jsonString = jsonObject.ToJsonString();
        _logger.LogDebug("jsonData:" + jsonString);
        return Ok(jsonString);
    }

    [HttpPost("PostAndParseJsonData")]
    public ActionResult PostAndParseJsonData([Required] JsonObject jsonObject)
    {
        var game = JsonSerializer.Deserialize<SquidGame>(jsonObject.ToJsonString());
        return Ok(JsonSerializer.Serialize(game));
    }

}
