using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI
{
    public class LibraryDictionary : IEnumerable
    {
        private int newId;
        private Dictionary<int, Library> _libraryDictionary = new Dictionary<int, Library>();
        public event EventHandler<Library> OnAdditionChange;
        public event EventHandler<int> OnRemovalChange;
        public int CurrentID { get { return newId; } }

        public LibraryDictionary()
        {
            newId = 0;
        }

        public void Add(Library library)
        {
            _libraryDictionary.Add(newId, library);
            OnAdditionChange?.Invoke(this, library);
            newId++;
        }

        public bool Remove(int id)
        {
            if (_libraryDictionary.ContainsKey(id))
            {
                _libraryDictionary.Remove(id);
                OnRemovalChange?.Invoke(this, id);
                return true;
            }
            return false;
        }

        public bool ContainsID(int id)
        {
            return _libraryDictionary.ContainsKey(id);
        }

        public Library? GetLibrary(int id)
        {
            if (_libraryDictionary.TryGetValue(id, out Library? library))
            {
                return library;
            }
            return null;
        }

        public int Size()
        {
            return _libraryDictionary.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return _libraryDictionary.Values.GetEnumerator();
        }
    }
}
