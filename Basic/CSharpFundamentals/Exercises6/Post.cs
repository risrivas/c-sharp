using System;

namespace Exercises6
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }

        private int Votes = 0;

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            if (Votes > 0)
            {
                Votes--;
            }
        }

        public int GetVotes()
        {
            return Votes;
        }
    }
}
