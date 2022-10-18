using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    //Using without abstract
    class Tutorial
    {
        protected int tutorialID;
        protected string tutorialName;

        //private void setTutorial(int tID, string tName) --> It shows an error while calling setTutorial

        public void setTutorial(int tID, string tName)
        {
            tutorialID = tID;
            tutorialName = tName;
        }

        public string getTutorial()
        {
            String data = tutorialID + " " + tutorialName;
            return data;
        }
    }

    //Use with abstraction
    //abstract class Tutorial
    //{
    //    public void setTutorial(int tID, string tName)
    //    {

    //    }

    //    public void getTutorial()
    //    {

    //    }
    //}

    //Use with Interface
    //public interface Tutorial
    //{
    //    public void setTutorial(int tID, string tName);
    //    public string getTutorial();
    //}
}
