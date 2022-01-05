﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_enroute_waypoints")]
    public partial class EnrouteWaypoint : Navigable
    {
        [Column("waypoint_identifier", TypeName = "TEXT(5)")]
        public string? Identifier { get; set; }
        [Column("waypoint_name", TypeName = "TEXT(25)")]
        public string? WaypointName { get; set; }
        [Column("waypoint_type", TypeName = "TEXT(3)")]
        public string? WaypointType { get; set; }
        [Column("waypoint_usage", TypeName = "TEXT(2)")]
        public string? WaypointUsage { get; set; }
        [Column("waypoint_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("waypoint_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
    }
}
