using System;
using System.Collections;
using System.Text;

namespace TextPlugin{
    public class EntryList{
        ArrayList entries;

        int entryMaxNumber;
        int currentIndex;

        public int MaxSize{
            get { return entryMaxNumber; }
            set { entryMaxNumber = value; }
        }

        public string this[int pos] {
            get { return entries[pos].ToString(); }
            set { entries[pos] = value; }
        }

        public int Count{
            get { return entries.Count; }
        }

        public EntryList(){
            entries = new ArrayList();
            currentIndex = 0;
        }

        public void Add(string text){
            if (entries.Count >= entryMaxNumber)
                entries.RemoveAt(0);

            entries.Insert(entries.Count, text);
        }

        public void Insert(int index, string text){
            entries.Insert(index, text);
        }
        
        public void RemoveAt(int pos){ 
            entries.RemoveAt(pos); 
        }

        public void Clear(){
            entries.Clear();
        }

        public bool Contains(string text){ 
            return entries.Contains(text); 
        }

        public string CurrentEntry(){
            if (entries.Count > 0)
                return (string)entries[currentIndex];
            else return null;
        }

        public string PreviousEntry(){
            if (entries.Count > 0){
                currentIndex--;

                if (currentIndex < 0)
                    currentIndex = 0;

                return (string)entries[currentIndex];
            }
            else return null;
        }
        
        public string NextEntry(){
            if (entries.Count > 0){
                currentIndex++;

                if (currentIndex > entries.Count - 1)
                    currentIndex = entries.Count - 1;

                return (string)entries[currentIndex];
            }
            else return null;
        }

        public void ResetEntryIndex(){
            currentIndex = 0;
        }
    }
}
