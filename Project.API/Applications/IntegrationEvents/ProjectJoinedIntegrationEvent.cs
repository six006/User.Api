﻿using Project.Domain.AggregatesModel;

namespace Project.API.Applications.IntegrationEvents
{
    public class ProjectJoinedIntegrationEvent
    {
        public ProjectContributor ProjectContributor { get; set; }
        public string Company { get; set; }
        public string Introduction { get; set; }
       
    }
}