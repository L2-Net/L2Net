using System.Collections;

namespace L2_login
{
    class ScriptThread
    {
        public ArrayList _stack = new ArrayList();
        public Stack _functioncalls = new Stack();
        public Stack _subcalls = new Stack();

        public int ID = 0;
        public int StackHeight = 0;
        public int Line_Pos = 0;
        public string Current_File = "";
        public System.DateTime Sleep_Until = System.DateTime.Today.AddDays(-100);

        public void Start()
        {
            Sleep_Until = System.DateTime.Today.AddDays(-100);
        }

        public void Stop()
        {
            Sleep_Until = System.DateTime.Today.AddDays(100);
        }

        public void Kill()
        {
            Stop();
            ScriptEngine.Threads.Remove(ID);
        }
    }
}
