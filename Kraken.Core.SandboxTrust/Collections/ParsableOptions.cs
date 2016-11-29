﻿namespace System.Collections {

  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class ParsableOptions {

    public ParsableOptions() { }
    public ParsableOptions(Hashtable ht) : this() {
      SetProperties(ht);
    }
    // TODO implement a json constructor

    public void SetProperties(Hashtable ht) {
      foreach (string key in ht.Keys) {
        SetProperty(key, ht[key]);
      }
    }

    public virtual bool SetProperty(string propertyName, object value) {
      ParseMessages.Add(string.Format("Unrecognized property name: '{0}'", propertyName));
      return false;
    }
    public List<string> ParseMessages { get; protected set; } = new List<string>();

  }
}
