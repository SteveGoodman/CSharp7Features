using System.Collections.Concurrent;

namespace CSharp7Console
{
    public class ExpressionsBodyMembersPerson
    {
        //Not available in c# 7 yet

        /*
        private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();
        private int id = GetId();

        private static int GetId()
        {
            throw new System.NotImplementedException();
        }

        public ExpressionsBodyMembersPerson(string name) => names.TryAdd(id, name); // constructors

        ~ExpressionsBodyMembersPerson() => names.TryRemove(id, out *);              // destructors

        public string Name
        {
            get => names[id];                                 // getters
            set => names[id] = value;                         // setters
        }
    */
    }
}
