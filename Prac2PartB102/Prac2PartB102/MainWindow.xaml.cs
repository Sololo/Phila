using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace Prac2PartB102
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string s)
        {
            int sum = 0;
            foreach(char i in s)
            {
                sum++;
            }
            return sum;
        }
        bool contains(string s, string subs)
        {
           for(int i=0; i < length(s); i++)
            {
                if (s[i] == subs[0])
                {
                    for(int b = 1; b < length(subs); b++)
                    {
                        i++;
                        if (s[i] == subs[b])
                        {
                            return true;
                        }
                        
                    }
                   if (length(subs) == 1)
                        {
                            return true;
                        } 
                }
               
            }
            return false;
        } 
        int indexOf(string s, string subs)
        {
            for (int i = 0; i < length(s); i++)
            {
                if (s[i] == subs[0])
                {
                    for (int b = 1; b < length(subs); b++)
                    {
                        i++;
                        if (s[i] == subs[b])
                        {
                            return b-1;
                        }

                    }
                    if (length(subs) == 1)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
        int stringCompare(string s1,string s2)
        {
           
            for(int i=0; i < length(s1); i++)
            {
                if (s1[i] == s2[0])
                {
                    i++;
                    for (int j = 1; j < length(s2); j++)
                    {
                        if (s1[i] == s2[j])
                        {
                            return 0;
                        }
                        
                    }
                }
                if (s1[i] < s2[0])
                {
                    return -1;
                }

                if (s1[i] > s2[0])
                {
                    return 1;
                }

            }
            return 0;
        }
        char lowers(char c)
        {
            switch (c)
            {
                case 'A': return 'a';
                case 'B': return 'b';
                case 'C': return 'c';
                case 'D': return 'd';
                case 'E': return 'e';
                case 'F': return 'f';
                case 'G': return 'g';
                case 'H': return 'h';
                case 'I': return 'i';
                case 'J': return 'j';
                case 'K': return 'k';
                case 'L': return 'l';
                case 'M': return 'm';
                case 'N': return 'n';
                case 'O': return 'o';
                case 'P': return 'p';
                case 'Q': return 'q';
                case 'R': return 'r';
                case 'S': return 's';
                case 'T': return 't';
                case 'U': return 'u';
                case 'V': return 'v';
                case 'W': return 'w';
                case 'X': return 'x';
                case 'Y': return 'y';
                case 'Z': return 'z';
                default:return c;
            }
        }
        string toLower(string s)
        {
            string lower = "";
            foreach(char i in s)
            {
                lower = lower + lowers(i);
            }
            return lower;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("xxx"), 3);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("xxyxx", "y"), true);
            Tester.TestEq(contains("how about this", "about"), true);
            Tester.TestEq(contains("regs richez saz", "y"), false);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(indexOf("xxyxx", "y"),2);
            Tester.TestEq(indexOf("bfbsdb", "s"), 3);
            Tester.TestEq(indexOf("xxy xx", " "), 3);



        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(stringCompare("xxx", "xxx"), 0);
            Tester.TestEq(stringCompare("abay", "xwz"), -1);
            Tester.TestEq(stringCompare( "xwz", "abay"), 1);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toLower("HeLLo"),"hello");
        }
    }
}
