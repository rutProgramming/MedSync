﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.API.Models;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;

namespace Train_project.Core.IServices
{
    public interface IMessageService
    {
       IEnumerable<StationDto> GetAllStations();
        StationDto? GetStationById(int id);
        StationDto AddStation(StationDto station);
        StationDto UpdateStation(int id, StationDto station);
       bool DeleteStation(int id);
       bool ValidData(StationDto station);
    }
}
