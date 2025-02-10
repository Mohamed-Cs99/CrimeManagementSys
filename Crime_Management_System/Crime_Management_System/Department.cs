using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//➢ Department Details:
//▪ Each department has an ID, name and date of activation.
//▪ Each department has a list of officers in that department.
//▪ Each department has a list of its cases.

namespace Crime_Management_System
{
    class Department
    {
        #region Attributes 
        private int id;
        private string name;
        private DateTime activation;
        private List<Officer> officersList = new List<Officer>();
        private List<Case> casesList = new List<Case>();
        #endregion

        #region Constructors 
        // Default Constructor
        public Department()
        {
        }

        // Parameterized Constructor
        public Department(int id, string name, DateTime activation, List<Officer> officersList, List<Case> casesList)
        {
            this.id = id;
            this.name = name;
            this.activation = activation;
            this.officersList = officersList;
            this.casesList = casesList;
        }
        #endregion

        #region Setters And Getters
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Activation
        {
            get { return this.activation; }
            set { this.activation = value; }
        }

        public List<Officer> OfficersList
        {
            get { return this.officersList; }
            set { this.officersList = value; }
        }

        public List<Case> CasesList
        {
            get { return this.casesList; }
            set { this.casesList = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Department ID: {id}, Name: {name}, Activation Date: {activation.ToShortDateString()}";
        }
        #endregion
    }
}
