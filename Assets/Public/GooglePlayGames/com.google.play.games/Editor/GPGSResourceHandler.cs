using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace GooglePlayGames.Editor
{
    public sealed class GPGSResourceHandler : ScriptableSingleton<GPGSResourceHandler>
    {
        public interface IHandler
        {
            void ResolveResourceIds(Hashtable resourceKeys);
        }

        public readonly HashSet<IHandler> handlers = new();

        public void ResolveResourceIds(Hashtable resourceKeys)
        {
            foreach (IHandler resolver in handlers)
            {
                resolver.ResolveResourceIds(resourceKeys);
            }
        }
    }
}