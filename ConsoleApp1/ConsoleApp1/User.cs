﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollectorLesson
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime? BlockedDate { get; set; }
    }
}
