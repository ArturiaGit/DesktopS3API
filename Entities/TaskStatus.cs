﻿using System;
using System.Collections.Generic;

namespace DesktopS3API.Entities
{
    public partial class TaskStatus
    {
        public TaskStatus()
        {
            TransporationTasks = new HashSet<TransporationTask>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TransporationTask> TransporationTasks { get; set; }
    }
}
