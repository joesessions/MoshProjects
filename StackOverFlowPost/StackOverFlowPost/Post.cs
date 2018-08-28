using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowPost
{
    class Post
    {

        public string Title;
        public string Description;
        public int Votes;


        public Post postCreate(string title, string description)
        {

            this.Title = title;
            this.Description = description;
            this.Votes = 0;
            return this; 
        }



        public void postUpVote()
        {
            this.Votes++;
            return;
        }

        public void postDownVote()
        {
            this.Votes--;
            return;
        }
    }
}
