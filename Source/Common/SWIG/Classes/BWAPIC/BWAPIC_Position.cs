/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPIC {
 
	// defaults
	using System; 
	using System.Runtime.InteropServices; 
	// BWAPI
	using BWAPI;

public partial class BWAPIC_Position : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BWAPIC_Position(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BWAPIC_Position obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BWAPIC_Position() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiclientPINVOKE.delete_BWAPIC_Position(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is BWAPIC_Position)
      equal = (((BWAPIC_Position)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(BWAPIC_Position obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(BWAPIC_Position obj1, BWAPIC_Position obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(BWAPIC_Position obj1, BWAPIC_Position obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public BWAPIC_Position() : this(bwapiclientPINVOKE.new_BWAPIC_Position(), true) {
  }

  public int x {
    set {
      bwapiclientPINVOKE.BWAPIC_Position_x_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.BWAPIC_Position_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      bwapiclientPINVOKE.BWAPIC_Position_y_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.BWAPIC_Position_y_get(swigCPtr);
      return ret;
    } 
  }

}

}
