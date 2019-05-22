using System;

namespace Lesson08_01Book
{
    public struct Book
    {
        public string Name;
        public string Id;
        public string InternalId;

        public void CreateInternalId()
        {
            InternalId = string.Format("{0}_{1}", Name, Id);
        }
    }
}
