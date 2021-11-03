using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbask
{
    class Program
    {
        static void Main(string[] args)
        {
            int fb_user_acc;
            Facebook[] fb_users;
            Console.WriteLine("Enter the no of facebook :");
            fb_user_acc = int.Parse(Console.ReadLine());
            fb_users = new Facebook[fb_user_acc];
            for(int i =0;i< fb_user_acc; i++)
            {
                string u_Fname;
                string u_Lastname;
                string u_email;
                long u_mobnum;
                DateTime u_dob;

                Console.WriteLine("enter fname");
                u_Fname = Console.ReadLine();
                Console.WriteLine("enter lname");
                u_Lastname = Console.ReadLine();
                Console.WriteLine("enter email");
                u_email = Console.ReadLine();
                Console.WriteLine("enter mobile number");
                u_mobnum =long.Parse( Console.ReadLine());
                Console.WriteLine("enter dob");
                u_dob = Convert.ToDateTime(Console.ReadLine());
                Facebook fb = new Facebook(u_Fname, u_Lastname, u_email, u_mobnum, u_dob);
                if (!fb_users.Contains(fb))
                {
                    fb_users[i] = fb;
                }
                else
                {
                    Console.WriteLine("account is exist");
                    i--;
                }
            }
        }
    }
}
