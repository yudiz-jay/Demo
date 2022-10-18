using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{

    // If we not extend the class we can't access tutorialName because of Protected accessmodifier.

    class myTutorial : Tutorial
    {

        //Use with abstraction
        //protected int tutorialID;
        //protected string tutorialname;

        //public void setTutorial(int tid, string tname)
        //{
        //    tutorialID = tid;
        //    tutorialname = tname;
        //}

        //public string getTutorial()
        //{
        //    string data = tutorialID + " " + tutorialname;
        //    return data;
        //}

        //Use with Interface
        //protected int tutorialID;
        //protected string tutorialname;

        //public void setTutorial(int tid, string tname)
        //{
        //    tutorialID = tid;
        //    tutorialname = tname;
        //}

        //public string getTutorial()
        //{
        //    string data = tutorialID + " " + tutorialname;
        //    return data;
        //}

        public void RenameTutorial(int tNewID,String tNewName)
        {
            tutorialID = tNewID;
            tutorialName = tNewName;
        }

        //it is compile time polymorphism
        //public void RenameTutorial(String tNewName)
        //{
        //    tutorialName = tNewName;
        //}
    }
}
