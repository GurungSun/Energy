using System;
using Energy.Models;
namespace Energy.Data;

public class TipsData
{
    public List<Tip> Tips { get; set; } = new List<Tip>
    {
        new Tip(Guid.NewGuid(), "Use Energy Efficient Appliances", "Switch to energy-efficient appliances to reduce energy consumption and save on utility bills."),
        new Tip(Guid.NewGuid(), "Unplug Devices When Not in Use", "Many devices consume energy even when turned off. Unplug them to save energy."),
        new Tip(Guid.NewGuid(), "Use LED Lighting", "LED bulbs use less energy and last longer than traditional incandescent bulbs."),
        new Tip(Guid.NewGuid(), "Insulate Your Home", "Proper insulation can help maintain a comfortable temperature and reduce heating and cooling costs."),
        new Tip(Guid.NewGuid(), "Use Smart Thermostats", "Smart thermostats can optimize heating and cooling schedules, saving energy when you're not home.")
    };
}