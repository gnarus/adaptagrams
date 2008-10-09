/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.adaptagrams.cola {

using System;
using System.Runtime.InteropServices;

public class ColaResizes : IDisposable, System.Collections.IEnumerable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ColaResizes(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ColaResizes obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ColaResizes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_ColaResizes(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ColaResizes(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (Resize element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Resize this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(System.Array array) {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(System.Array array, int arrayIndex) {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, System.Array array, int arrayIndex, int count) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  // Type-safe version of IEnumerable.GetEnumerator
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new ColaResizesEnumerator(this);
  }

  public ColaResizesEnumerator GetEnumerator() {
    return new ColaResizesEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ColaResizesEnumerator : System.Collections.IEnumerator {
    private ColaResizes collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ColaResizesEnumerator(ColaResizes collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Resize Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (Resize)currentObject;
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
        currentObject = collectionRef[currentIndex];
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
  }

  public void Clear() {
    colaPINVOKE.ColaResizes_Clear(swigCPtr);
  }

  public void Add(Resize x) {
    colaPINVOKE.ColaResizes_Add(swigCPtr, Resize.getCPtr(x));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = colaPINVOKE.ColaResizes_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = colaPINVOKE.ColaResizes_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    colaPINVOKE.ColaResizes_reserve(swigCPtr, n);
  }

  public ColaResizes() : this(colaPINVOKE.new_ColaResizes__SWIG_0(), true) {
  }

  public ColaResizes(int capacity) : this(colaPINVOKE.new_ColaResizes__SWIG_1(capacity), true) {
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  private Resize getitemcopy(int index) {
    Resize ret = new Resize(colaPINVOKE.ColaResizes_getitemcopy(swigCPtr, index), true);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Resize getitem(int index) {
    Resize ret = new Resize(colaPINVOKE.ColaResizes_getitem(swigCPtr, index), false);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Resize val) {
    colaPINVOKE.ColaResizes_setitem(swigCPtr, index, Resize.getCPtr(val));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(ColaResizes values) {
    colaPINVOKE.ColaResizes_AddRange(swigCPtr, ColaResizes.getCPtr(values));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public ColaResizes GetRange(int index, int count) {
    IntPtr cPtr = colaPINVOKE.ColaResizes_GetRange(swigCPtr, index, count);
    ColaResizes ret = (cPtr == IntPtr.Zero) ? null : new ColaResizes(cPtr, true);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Resize x) {
    colaPINVOKE.ColaResizes_Insert(swigCPtr, index, Resize.getCPtr(x));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, ColaResizes values) {
    colaPINVOKE.ColaResizes_InsertRange(swigCPtr, index, ColaResizes.getCPtr(values));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    colaPINVOKE.ColaResizes_RemoveAt(swigCPtr, index);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    colaPINVOKE.ColaResizes_RemoveRange(swigCPtr, index, count);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ColaResizes Repeat(Resize value, int count) {
    IntPtr cPtr = colaPINVOKE.ColaResizes_Repeat(Resize.getCPtr(value), count);
    ColaResizes ret = (cPtr == IntPtr.Zero) ? null : new ColaResizes(cPtr, true);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    colaPINVOKE.ColaResizes_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    colaPINVOKE.ColaResizes_Reverse__SWIG_1(swigCPtr, index, count);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, ColaResizes values) {
    colaPINVOKE.ColaResizes_SetRange(swigCPtr, index, ColaResizes.getCPtr(values));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

}

}