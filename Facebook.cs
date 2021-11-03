using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbask
{
    class Facebook
    {
        string Fname;
        string Lastname;
        string email;
        long mobnum;
        DateTime dob;

        public Facebook()
        {
        }

        public Facebook(string fname1, string lastname1, string email, long mobnum, DateTime dob)
        {
            Fname1 = fname1;
            Lastname1 = lastname1;
            Email = email;
            Mobnum = mobnum;
            Dob = dob;
        }

        public string Fname1 { get => Fname; set => Fname = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        public string Email { get => email; set => email = value; }
        public long Mobnum { get => mobnum; set => mobnum = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public override bool Equals(object obj)
        {
            Facebook fb = (Facebook)obj;
            return this.Email.Equals(fb.Email) && this.Mobnum.Equals(fb.Mobnum);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return String.Format("{0,15},{1,15},{2,15},{3,15}", Fname + Lastname1, Email, Mobnum, Dob);
        }

    }
}
