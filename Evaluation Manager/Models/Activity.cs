﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class Activity {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string MaxPoints { get; set; }

        public string MinPointsForGrade { get; set; }

        public string MinPointsForSignature { get; set; }

        public override string ToString() {
            return Name;
        }
    }
