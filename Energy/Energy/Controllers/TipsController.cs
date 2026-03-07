using System;
using Energy.Models;
using Energy.Data;
using Energy.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Energy.Services;

[ApiController]
[Route("api/[controller]")]

public class TipsController
{
    private readonly TipsService _tipsService;

    public TipsController(TipsService tipService)
    {
        _tipsService = tipService;
    }

    public List<Tip> GetTips()
    {
        var tips = _tipsService.GetTips();
        return tips;
    }
}