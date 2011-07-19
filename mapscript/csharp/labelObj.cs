/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.31
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class labelObj : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal labelObj(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(labelObj obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~labelObj() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_labelObj(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public string font {
    set {
      mapscriptPINVOKE.labelObj_font_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.labelObj_font_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MS_FONT_TYPE type {
    set {
      mapscriptPINVOKE.labelObj_type_set(swigCPtr, (int)value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      MS_FONT_TYPE ret = (MS_FONT_TYPE)mapscriptPINVOKE.labelObj_type_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj color {
    set {
      mapscriptPINVOKE.labelObj_color_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.labelObj_color_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj outlinecolor {
    set {
      mapscriptPINVOKE.labelObj_outlinecolor_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.labelObj_outlinecolor_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj shadowcolor {
    set {
      mapscriptPINVOKE.labelObj_shadowcolor_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.labelObj_shadowcolor_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int shadowsizex {
    set {
      mapscriptPINVOKE.labelObj_shadowsizex_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_shadowsizex_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int shadowsizey {
    set {
      mapscriptPINVOKE.labelObj_shadowsizey_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_shadowsizey_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj backgroundcolor {
    set {
      mapscriptPINVOKE.labelObj_backgroundcolor_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.labelObj_backgroundcolor_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj backgroundshadowcolor {
    set {
      mapscriptPINVOKE.labelObj_backgroundshadowcolor_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.labelObj_backgroundshadowcolor_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int backgroundshadowsizex {
    set {
      mapscriptPINVOKE.labelObj_backgroundshadowsizex_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_backgroundshadowsizex_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int backgroundshadowsizey {
    set {
      mapscriptPINVOKE.labelObj_backgroundshadowsizey_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_backgroundshadowsizey_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int size {
    set {
      mapscriptPINVOKE.labelObj_size_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_size_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int minsize {
    set {
      mapscriptPINVOKE.labelObj_minsize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_minsize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int maxsize {
    set {
      mapscriptPINVOKE.labelObj_maxsize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_maxsize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int position {
    set {
      mapscriptPINVOKE.labelObj_position_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_position_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int offsetx {
    set {
      mapscriptPINVOKE.labelObj_offsetx_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_offsetx_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int offsety {
    set {
      mapscriptPINVOKE.labelObj_offsety_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_offsety_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double angle {
    set {
      mapscriptPINVOKE.labelObj_angle_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.labelObj_angle_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int autoangle {
    set {
      mapscriptPINVOKE.labelObj_autoangle_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_autoangle_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int autofollow {
    set {
      mapscriptPINVOKE.labelObj_autofollow_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_autofollow_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int buffer {
    set {
      mapscriptPINVOKE.labelObj_buffer_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_buffer_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int antialias {
    set {
      mapscriptPINVOKE.labelObj_antialias_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_antialias_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public char wrap {
    set {
      mapscriptPINVOKE.labelObj_wrap_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      char ret = mapscriptPINVOKE.labelObj_wrap_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int minfeaturesize {
    set {
      mapscriptPINVOKE.labelObj_minfeaturesize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_minfeaturesize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int autominfeaturesize {
    set {
      mapscriptPINVOKE.labelObj_autominfeaturesize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_autominfeaturesize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int mindistance {
    set {
      mapscriptPINVOKE.labelObj_mindistance_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_mindistance_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int partials {
    set {
      mapscriptPINVOKE.labelObj_partials_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_partials_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int force {
    set {
      mapscriptPINVOKE.labelObj_force_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_force_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string encoding {
    set {
      mapscriptPINVOKE.labelObj_encoding_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.labelObj_encoding_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int priority {
    set {
      mapscriptPINVOKE.labelObj_priority_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.labelObj_priority_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int updateFromString(string snippet) {
    int ret = mapscriptPINVOKE.labelObj_updateFromString(swigCPtr, snippet);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int removeBinding(int binding) {
    int ret = mapscriptPINVOKE.labelObj_removeBinding(swigCPtr, binding);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setBinding(int binding, string item) {
    int ret = mapscriptPINVOKE.labelObj_setBinding(swigCPtr, binding, item);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public labelObj() : this(mapscriptPINVOKE.new_labelObj(), true) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

}
