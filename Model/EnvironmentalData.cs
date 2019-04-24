using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SEP_DataAPI.Model
{
    public class EnvironmentalData
    {
    private String location;
    private double CO2;
    private double temperature;
    private String time;

    public EnvironmentalData(String location, double CO2, double temperature, String time) {
        this.location = location;
        this.CO2 = CO2;
        this.temperature = temperature;
        this.time = time;
    }

    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public double getCO2() {
        return CO2;
    }

    public void setCO2(double CO2) {
        this.CO2 = CO2;
    }

    public double getTemperature() {
        return temperature;
    }

    public void setTemperature(double temperature) {
        this.temperature = temperature;
    }

    public String getTime() {
        return time;
    }

    public void setTime(String time) {
        this.time = time;
    }

    }
}