﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Atlas.Shared.Models.Admin.Events
{
    public class TargetModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public IList<EventModel> Events { get; set; } = new List<EventModel>();

        public class EventModel
        {
            public Guid Id { get; set; }
            public DateTime TimeStamp { get; set; }
            public string Type { get; set; }
            public Guid? MemberId { get; set; }
            public string MemberName { get; set; }
            public Dictionary<string, string> Data { get; set; }
        }
    }
}
