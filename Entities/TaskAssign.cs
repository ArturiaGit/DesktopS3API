﻿using System;
using System.Collections.Generic;

namespace DesktopS3API.Entities
{
    public partial class TaskAssign
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int VehicleId { get; set; }

        public virtual TransporationTask Task { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
