/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class shapefileObj : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  internal shapefileObj(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(shapefileObj obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  internal static HandleRef getCPtrAndDisown(shapefileObj obj, object parent) {
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
  internal static HandleRef getCPtrAndSetReference(shapefileObj obj, object parent) {
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

  ~shapefileObj() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_shapefileObj(swigCPtr);
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
    return swigCPtr.Handle.Equals(shapefileObj.getCPtr((shapefileObj)obj).Handle);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public string source {
    get {
      string ret = mapscriptPINVOKE.shapefileObj_source_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int type {
    get {
      int ret = mapscriptPINVOKE.shapefileObj_type_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int numshapes {
    get {
      int ret = mapscriptPINVOKE.shapefileObj_numshapes_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public rectObj bounds {
    get {
      IntPtr cPtr = mapscriptPINVOKE.shapefileObj_bounds_get(swigCPtr);
      rectObj ret = (cPtr == IntPtr.Zero) ? null : new rectObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int lastshape {
    get {
      int ret = mapscriptPINVOKE.shapefileObj_lastshape_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t status {
    get {
      IntPtr cPtr = mapscriptPINVOKE.shapefileObj_status_get(swigCPtr);
      SWIGTYPE_p_uint32_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_uint32_t(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public rectObj statusbounds {
    get {
      IntPtr cPtr = mapscriptPINVOKE.shapefileObj_statusbounds_get(swigCPtr);
      rectObj ret = (cPtr == IntPtr.Zero) ? null : new rectObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int isopen {
    get {
      int ret = mapscriptPINVOKE.shapefileObj_isopen_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public shapefileObj(string filename, int type) : this(mapscriptPINVOKE.new_shapefileObj(filename, type), true, null) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public int get(int i, shapeObj shape) {
    int ret = mapscriptPINVOKE.shapefileObj_get(swigCPtr, i, shapeObj.getCPtr(shape));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public shapeObj getShape(int i) {
    IntPtr cPtr = mapscriptPINVOKE.shapefileObj_getShape(swigCPtr, i);
    shapeObj ret = (cPtr == IntPtr.Zero) ? null : new shapeObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getPoint(int i, pointObj point) {
    int ret = mapscriptPINVOKE.shapefileObj_getPoint(swigCPtr, i, pointObj.getCPtr(point));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getTransformed(mapObj map, int i, shapeObj shape) {
    int ret = mapscriptPINVOKE.shapefileObj_getTransformed(swigCPtr, mapObj.getCPtr(map), i, shapeObj.getCPtr(shape));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getExtent(int i, rectObj rect) {
    mapscriptPINVOKE.shapefileObj_getExtent(swigCPtr, i, rectObj.getCPtr(rect));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public int add(shapeObj shape) {
    int ret = mapscriptPINVOKE.shapefileObj_add(swigCPtr, shapeObj.getCPtr(shape));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int addPoint(pointObj point) {
    int ret = mapscriptPINVOKE.shapefileObj_addPoint(swigCPtr, pointObj.getCPtr(point));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DBFInfo getDBF() {
    IntPtr cPtr = mapscriptPINVOKE.shapefileObj_getDBF(swigCPtr);
    DBFInfo ret = (cPtr == IntPtr.Zero) ? null : new DBFInfo(cPtr, false, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}