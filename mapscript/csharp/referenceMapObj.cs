/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class referenceMapObj : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  internal referenceMapObj(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(referenceMapObj obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  internal static HandleRef getCPtrAndDisown(referenceMapObj obj, object parent) {
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
  internal static HandleRef getCPtrAndSetReference(referenceMapObj obj, object parent) {
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

  ~referenceMapObj() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_referenceMapObj(swigCPtr);
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
    return swigCPtr.Handle.Equals(referenceMapObj.getCPtr((referenceMapObj)obj).Handle);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public rectObj extent {
    set {
      mapscriptPINVOKE.referenceMapObj_extent_set(swigCPtr, rectObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.referenceMapObj_extent_get(swigCPtr);
      rectObj ret = (cPtr == IntPtr.Zero) ? null : new rectObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int height {
    set {
      mapscriptPINVOKE.referenceMapObj_height_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_height_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int width {
    set {
      mapscriptPINVOKE.referenceMapObj_width_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_width_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj color {
    set {
      mapscriptPINVOKE.referenceMapObj_color_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.referenceMapObj_color_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj outlinecolor {
    set {
      mapscriptPINVOKE.referenceMapObj_outlinecolor_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.referenceMapObj_outlinecolor_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string image {
    set {
      mapscriptPINVOKE.referenceMapObj_image_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.referenceMapObj_image_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int status {
    set {
      mapscriptPINVOKE.referenceMapObj_status_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_status_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int marker {
    set {
      mapscriptPINVOKE.referenceMapObj_marker_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_marker_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string markername {
    set {
      mapscriptPINVOKE.referenceMapObj_markername_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.referenceMapObj_markername_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int markersize {
    set {
      mapscriptPINVOKE.referenceMapObj_markersize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_markersize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int minboxsize {
    set {
      mapscriptPINVOKE.referenceMapObj_minboxsize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_minboxsize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int maxboxsize {
    set {
      mapscriptPINVOKE.referenceMapObj_maxboxsize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.referenceMapObj_maxboxsize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public mapObj map {
    get {
      IntPtr cPtr = mapscriptPINVOKE.referenceMapObj_map_get(swigCPtr);
      mapObj ret = (cPtr == IntPtr.Zero) ? null : new mapObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int updateFromString(string snippet) {
    int ret = mapscriptPINVOKE.referenceMapObj_updateFromString(swigCPtr, snippet);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public referenceMapObj() : this(mapscriptPINVOKE.new_referenceMapObj(), true, null) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

}
