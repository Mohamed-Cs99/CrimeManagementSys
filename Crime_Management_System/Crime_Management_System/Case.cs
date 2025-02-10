using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//➢Case Details:
//▪ Each case has an ID, description and Start date of working on it and the date of last updates on the case.
//▪ Each case has a crime type (Murder/Robbery/Assault,..).
//▪ Each case belongs to a department.
//▪ Each case has officers assigned to it.
//▪ Each case has criminals involved in it.

namespace Crime_Management_System
{
    class Case
    {
        #region Attributes
        private int id;
        private string description;
        private string crimeType;
        private DateTime startDate;
        private DateTime lastUpdate;
        private Department department;
        private List<Officer> officers = new List<Officer>(); // Updated to a list of officers
        private List<Criminal> criminals = new List<Criminal>();
        #endregion

        #region Constructors
        // Default Constructor
        public Case()
        {
        }

        // Parameterized Constructor
        public Case(int id, string description, string crimeType, DateTime startDate, DateTime lastUpdate, Department department, List<Officer> officers, List<Criminal> criminals)
        {
            this.id = id;
            this.description = description;
            this.crimeType = crimeType;
            this.startDate = startDate;
            this.lastUpdate = lastUpdate;
            this.department = department;
            this.officers = officers; // Updated
            this.criminals = criminals;
        }
        #endregion

        #region Setters And Getters
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string CrimeType
        {
            get { return this.crimeType; }
            set { this.crimeType = value; }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public DateTime LastUpdate
        {
            get { return this.lastUpdate; }
            set { this.lastUpdate = value; }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public List<Officer> Officers // Updated
        {
            get { return this.officers; }
            set { this.officers = value; }
        }

        public List<Criminal> Criminals
        {
            get { return this.criminals; }
            set { this.criminals = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Case ID: {id}, Description: {description}, Crime Type: {crimeType}, Start Date: {startDate.ToShortDateString()}, Last Update: {lastUpdate.ToShortDateString()}";
        }
        #endregion
    }
}
