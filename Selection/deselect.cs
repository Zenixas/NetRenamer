using System.Linq;

namespace NetRenamer.Selection
{
    internal class deselect
    {
        public static void all()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < List.tcb.ElementAt(i).Items.Count; j++)
                {
                    List.tcb.ElementAt(i).SetItemChecked(j, false);
                }
            }
        }

        public static void current(int selectedtab)
        {
            for (int i = 0; i < List.tcb.ElementAt(selectedtab).Items.Count; i++)
            {
                List.tcb.ElementAt(selectedtab).SetItemChecked(i, false);
            }
        }
    }
}