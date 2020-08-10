﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DingDingPuls.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            NoEquNameList = new List<string>();
            NoCreatNumberList = new List<string>();
            NoFinshedId = new List<int>();

            EquNameList = new List<string>();
            CreateNumberList = new List<string>();
            FinshedId = new List<int>();
        }

        public List<int> FinshedId { get; set; }

        public List<int> NoFinshedId { get; set; }

        public string PlanNumber { get; set; }

        public List<string> NoEquNameList { get; set; }

        public List<string> NoCreatNumberList { get; set; }

        public string EquName { get; set; }

        public string CreatNumber { get; set; }

        public List<string> EquNameList { get; set; }

        public List<string> CreateNumberList { get; set; }

        public DateTime CheckPlanTime { get; set; }

        public DateTime CheckStartTime { get; set; }

        public DateTime CheckEndTime { get; set; }

        public string Applicant { get; set; }

        public string Leader { get; set; }
        public string WorkerName { get; set; }

        public string CheckAreas { get; set; }

        public string CheckResult { get; set; }

        public string CheckCyc { get; set; }
        public string CheckStatus { get; set; }
        public int IsFinshed { get; set; }
        public decimal CheckCost { get; set; }
        public string Note { get; set; }
    }
}