/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class BulletTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<BulletType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BulletTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BulletTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BulletTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_BulletTypeSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<BulletType> Values {
    get {
      System.Collections.Generic.ICollection<BulletType> values = new System.Collections.Generic.List<BulletType>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(BulletType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(BulletType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( BulletType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<BulletType> keyList = new System.Collections.Generic.List<BulletType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      BulletType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< BulletType> System.Collections.Generic.IEnumerable<BulletType>.GetEnumerator() {
    return new BulletTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new BulletTypeSetEnumerator(this);
  }

  public BulletTypeSetEnumerator GetEnumerator() {
    return new BulletTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class BulletTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< BulletType>
  {
    private BulletTypeSet collectionRef;
    private System.Collections.Generic.IList<BulletType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public BulletTypeSetEnumerator(BulletTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<BulletType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  BulletType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( BulletType)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        BulletType currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
#endif
  

  public BulletTypeSet() : this(bwapiPINVOKE.new_BulletTypeSet__SWIG_0(), true) {
  }

  public BulletTypeSet(BulletTypeSet other) : this(bwapiPINVOKE.new_BulletTypeSet__SWIG_1(BulletTypeSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.BulletTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.BulletTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.BulletTypeSet_Clear(swigCPtr);
  }

  public BulletType getitem(BulletType key) {
    BulletType ret = new BulletType(bwapiPINVOKE.BulletTypeSet_getitem(swigCPtr, BulletType.getCPtr(key)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(BulletType key) {
    bool ret = bwapiPINVOKE.BulletTypeSet_ContainsKey(swigCPtr, BulletType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(BulletType key) {
    bwapiPINVOKE.BulletTypeSet_Add(swigCPtr, BulletType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(BulletType key) {
    bool ret = bwapiPINVOKE.BulletTypeSet_Remove(swigCPtr, BulletType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bwapiPINVOKE.BulletTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public BulletType get_next_key(IntPtr swigiterator) {
    BulletType ret = new BulletType(bwapiPINVOKE.BulletTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
