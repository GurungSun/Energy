using System;
using Energy.Models;
using Energy.Data;
namespace Energy.Services;

public class TipsService
{
    List<Tip> tips = new();

    public TipsService(TipsData data)
    {
        tips = data.Tips;
    }

    public List<Tip> GetTips()
    {
        return tips;
    }
}