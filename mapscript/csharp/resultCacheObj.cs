/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class resultCacheObj : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  internal resultCacheObj(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(resultCacheObj obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  internal static HandleRef getCPtrAndDisown(resultCacheObj obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  internal static HandleRef getCPtrAndSetReference(resultCacheObj obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~resultCacheObj() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_resultCacheObj(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public override bool Equals(object obj) {
    if (obj == null)
        return false;
    if (this.GetType() != obj.GetType())
        return false;
    return swigCPtr.Handle.Equals(resultCacheObj.getCPtr((resultCacheObj)obj).Handle);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public int numresults {
    get {
      int ret = mapscriptPINVOKE.resultCacheObj_numresults_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public rectObj bounds {
    get {
      IntPtr cPtr = mapscriptPINVOKE.resultCacheObj_bounds_get(swigCPtr);
      rectObj ret = (cPtr == IntPtr.Zero) ? null : new rectObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int usegetshape {
    set {
      mapscriptPINVOKE.resultCacheObj_usegetshape_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.resultCacheObj_usegetshape_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public resultCacheMemberObj getResult(int i) {
    IntPtr cPtr = mapscriptPINVOKE.resultCacheObj_getResult(swigCPtr, i);
    resultCacheMemberObj ret = (cPtr == IntPtr.Zero) ? null : new resultCacheMemberObj(cPtr, false, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public resultCacheObj() : this(mapscriptPINVOKE.new_resultCacheObj(), true, null) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

}
