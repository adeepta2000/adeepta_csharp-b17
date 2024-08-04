using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Member
    {
        private string membershipId;
        public string Name { get; set; }
        protected DateTime MembershipExpirationDate { get; set; }

        public Member()
        {
            membershipId = Guid.NewGuid().ToString();
        }
    }
}
