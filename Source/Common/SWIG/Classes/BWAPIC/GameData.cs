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

public partial class GameData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GameData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GameData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GameData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiclientPINVOKE.delete_GameData(swigCPtr);
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
    if (obj is GameData)
      equal = (((GameData)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(GameData obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(GameData obj1, GameData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(GameData obj1, GameData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public GameData() : this(bwapiclientPINVOKE.new_GameData(), true) {
  }

  public int revision {
    set {
      bwapiclientPINVOKE.GameData_revision_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_revision_get(swigCPtr);
      return ret;
    } 
  }

  public bool isDebug {
    set {
      bwapiclientPINVOKE.GameData_isDebug_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_isDebug_get(swigCPtr);
      return ret;
    } 
  }

  public int instanceID {
    set {
      bwapiclientPINVOKE.GameData_instanceID_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_instanceID_get(swigCPtr);
      return ret;
    } 
  }

  public int forceCount {
    set {
      bwapiclientPINVOKE.GameData_forceCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_forceCount_get(swigCPtr);
      return ret;
    } 
  }

  public ForceData forces {
    set {
      bwapiclientPINVOKE.GameData_forces_set(swigCPtr, ForceData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_forces_get(swigCPtr);
      ForceData ret = (cPtr == IntPtr.Zero) ? null : new ForceData(cPtr, false);
      return ret;
    } 
  }

  public int playerCount {
    set {
      bwapiclientPINVOKE.GameData_playerCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_playerCount_get(swigCPtr);
      return ret;
    } 
  }

  public PlayerData players {
    set {
      bwapiclientPINVOKE.GameData_players_set(swigCPtr, PlayerData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_players_get(swigCPtr);
      PlayerData ret = (cPtr == IntPtr.Zero) ? null : new PlayerData(cPtr, false);
      return ret;
    } 
  }

  public int initialUnitCount {
    set {
      bwapiclientPINVOKE.GameData_initialUnitCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_initialUnitCount_get(swigCPtr);
      return ret;
    } 
  }

  public UnitData units {
    set {
      bwapiclientPINVOKE.GameData_units_set(swigCPtr, UnitData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_units_get(swigCPtr);
      UnitData ret = (cPtr == IntPtr.Zero) ? null : new UnitData(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int unitArray {
    set {
      bwapiclientPINVOKE.GameData_unitArray_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_unitArray_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public BulletData bullets {
    set {
      bwapiclientPINVOKE.GameData_bullets_set(swigCPtr, BulletData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_bullets_get(swigCPtr);
      BulletData ret = (cPtr == IntPtr.Zero) ? null : new BulletData(cPtr, false);
      return ret;
    } 
  }

  public int nukeDotCount {
    set {
      bwapiclientPINVOKE.GameData_nukeDotCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_nukeDotCount_get(swigCPtr);
      return ret;
    } 
  }

  public BWAPIC_Position nukeDots {
    set {
      bwapiclientPINVOKE.GameData_nukeDots_set(swigCPtr, BWAPIC_Position.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_nukeDots_get(swigCPtr);
      BWAPIC_Position ret = (cPtr == IntPtr.Zero) ? null : new BWAPIC_Position(cPtr, false);
      return ret;
    } 
  }

  public int gameType {
    set {
      bwapiclientPINVOKE.GameData_gameType_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_gameType_get(swigCPtr);
      return ret;
    } 
  }

  public int latency {
    set {
      bwapiclientPINVOKE.GameData_latency_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_latency_get(swigCPtr);
      return ret;
    } 
  }

  public int latencyFrames {
    set {
      bwapiclientPINVOKE.GameData_latencyFrames_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_latencyFrames_get(swigCPtr);
      return ret;
    } 
  }

  public int latencyTime {
    set {
      bwapiclientPINVOKE.GameData_latencyTime_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_latencyTime_get(swigCPtr);
      return ret;
    } 
  }

  public int remainingLatencyFrames {
    set {
      bwapiclientPINVOKE.GameData_remainingLatencyFrames_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_remainingLatencyFrames_get(swigCPtr);
      return ret;
    } 
  }

  public int remainingLatencyTime {
    set {
      bwapiclientPINVOKE.GameData_remainingLatencyTime_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_remainingLatencyTime_get(swigCPtr);
      return ret;
    } 
  }

  public bool hasLatCom {
    set {
      bwapiclientPINVOKE.GameData_hasLatCom_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_hasLatCom_get(swigCPtr);
      return ret;
    } 
  }

  public int replayFrameCount {
    set {
      bwapiclientPINVOKE.GameData_replayFrameCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_replayFrameCount_get(swigCPtr);
      return ret;
    } 
  }

  public int frameCount {
    set {
      bwapiclientPINVOKE.GameData_frameCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_frameCount_get(swigCPtr);
      return ret;
    } 
  }

  public int fps {
    set {
      bwapiclientPINVOKE.GameData_fps_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_fps_get(swigCPtr);
      return ret;
    } 
  }

  public double averageFPS {
    set {
      bwapiclientPINVOKE.GameData_averageFPS_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiclientPINVOKE.GameData_averageFPS_get(swigCPtr);
      return ret;
    } 
  }

  public int mouseX {
    set {
      bwapiclientPINVOKE.GameData_mouseX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_mouseX_get(swigCPtr);
      return ret;
    } 
  }

  public int mouseY {
    set {
      bwapiclientPINVOKE.GameData_mouseY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_mouseY_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool mouseState {
    set {
      bwapiclientPINVOKE.GameData_mouseState_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_mouseState_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool keyState {
    set {
      bwapiclientPINVOKE.GameData_keyState_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_keyState_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public int screenX {
    set {
      bwapiclientPINVOKE.GameData_screenX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_screenX_get(swigCPtr);
      return ret;
    } 
  }

  public int screenY {
    set {
      bwapiclientPINVOKE.GameData_screenY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_screenY_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool flags {
    set {
      bwapiclientPINVOKE.GameData_flags_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_flags_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public int mapWidth {
    set {
      bwapiclientPINVOKE.GameData_mapWidth_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_mapWidth_get(swigCPtr);
      return ret;
    } 
  }

  public int mapHeight {
    set {
      bwapiclientPINVOKE.GameData_mapHeight_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_mapHeight_get(swigCPtr);
      return ret;
    } 
  }

  public string mapFileName {
    set {
      bwapiclientPINVOKE.GameData_mapFileName_set(swigCPtr, value);
    } 
    get {
      string ret = bwapiclientPINVOKE.GameData_mapFileName_get(swigCPtr);
      return ret;
    } 
  }

  public string mapPathName {
    set {
      bwapiclientPINVOKE.GameData_mapPathName_set(swigCPtr, value);
    } 
    get {
      string ret = bwapiclientPINVOKE.GameData_mapPathName_get(swigCPtr);
      return ret;
    } 
  }

  public string mapName {
    set {
      bwapiclientPINVOKE.GameData_mapName_set(swigCPtr, value);
    } 
    get {
      string ret = bwapiclientPINVOKE.GameData_mapName_get(swigCPtr);
      return ret;
    } 
  }

  public string mapHash {
    set {
      bwapiclientPINVOKE.GameData_mapHash_set(swigCPtr, value);
    } 
    get {
      string ret = bwapiclientPINVOKE.GameData_mapHash_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__int getGroundHeight {
    set {
      bwapiclientPINVOKE.GameData_getGroundHeight_set(swigCPtr, SWIGTYPE_p_a_256__int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_getGroundHeight_get(swigCPtr);
      SWIGTYPE_p_a_256__int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_1024__bool isWalkable {
    set {
      bwapiclientPINVOKE.GameData_isWalkable_set(swigCPtr, SWIGTYPE_p_a_1024__bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_isWalkable_get(swigCPtr);
      SWIGTYPE_p_a_1024__bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_1024__bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__bool isBuildable {
    set {
      bwapiclientPINVOKE.GameData_isBuildable_set(swigCPtr, SWIGTYPE_p_a_256__bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_isBuildable_get(swigCPtr);
      SWIGTYPE_p_a_256__bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__bool isVisible {
    set {
      bwapiclientPINVOKE.GameData_isVisible_set(swigCPtr, SWIGTYPE_p_a_256__bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_isVisible_get(swigCPtr);
      SWIGTYPE_p_a_256__bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__bool isExplored {
    set {
      bwapiclientPINVOKE.GameData_isExplored_set(swigCPtr, SWIGTYPE_p_a_256__bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_isExplored_get(swigCPtr);
      SWIGTYPE_p_a_256__bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__bool hasCreep {
    set {
      bwapiclientPINVOKE.GameData_hasCreep_set(swigCPtr, SWIGTYPE_p_a_256__bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_hasCreep_get(swigCPtr);
      SWIGTYPE_p_a_256__bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__bool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__unsigned_short mapTileRegionId {
    set {
      bwapiclientPINVOKE.GameData_mapTileRegionId_set(swigCPtr, SWIGTYPE_p_a_256__unsigned_short.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_mapTileRegionId_get(swigCPtr);
      SWIGTYPE_p_a_256__unsigned_short ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short mapSplitTilesMiniTileMask {
    set {
      bwapiclientPINVOKE.GameData_mapSplitTilesMiniTileMask_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_mapSplitTilesMiniTileMask_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short mapSplitTilesRegion1 {
    set {
      bwapiclientPINVOKE.GameData_mapSplitTilesRegion1_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_mapSplitTilesRegion1_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short mapSplitTilesRegion2 {
    set {
      bwapiclientPINVOKE.GameData_mapSplitTilesRegion2_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_mapSplitTilesRegion2_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short regionGroupIndex {
    set {
      bwapiclientPINVOKE.GameData_regionGroupIndex_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_regionGroupIndex_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public int startLocationCount {
    set {
      bwapiclientPINVOKE.GameData_startLocationCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_startLocationCount_get(swigCPtr);
      return ret;
    } 
  }

  public BWAPIC_Position startLocations {
    set {
      bwapiclientPINVOKE.GameData_startLocations_set(swigCPtr, BWAPIC_Position.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_startLocations_get(swigCPtr);
      BWAPIC_Position ret = (cPtr == IntPtr.Zero) ? null : new BWAPIC_Position(cPtr, false);
      return ret;
    } 
  }

  public bool isInGame {
    set {
      bwapiclientPINVOKE.GameData_isInGame_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_isInGame_get(swigCPtr);
      return ret;
    } 
  }

  public bool isMultiplayer {
    set {
      bwapiclientPINVOKE.GameData_isMultiplayer_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_isMultiplayer_get(swigCPtr);
      return ret;
    } 
  }

  public bool isBattleNet {
    set {
      bwapiclientPINVOKE.GameData_isBattleNet_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_isBattleNet_get(swigCPtr);
      return ret;
    } 
  }

  public bool isPaused {
    set {
      bwapiclientPINVOKE.GameData_isPaused_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_isPaused_get(swigCPtr);
      return ret;
    } 
  }

  public bool isReplay {
    set {
      bwapiclientPINVOKE.GameData_isReplay_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.GameData_isReplay_get(swigCPtr);
      return ret;
    } 
  }

  public int selectedUnitCount {
    set {
      bwapiclientPINVOKE.GameData_selectedUnitCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_selectedUnitCount_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int selectedUnits {
    set {
      bwapiclientPINVOKE.GameData_selectedUnits_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_selectedUnits_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public int self {
    set {
      bwapiclientPINVOKE.GameData_self_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_self_get(swigCPtr);
      return ret;
    } 
  }

  public int enemy {
    set {
      bwapiclientPINVOKE.GameData_enemy_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_enemy_get(swigCPtr);
      return ret;
    } 
  }

  public int neutral {
    set {
      bwapiclientPINVOKE.GameData_neutral_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_neutral_get(swigCPtr);
      return ret;
    } 
  }

  public int eventCount {
    set {
      bwapiclientPINVOKE.GameData_eventCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_eventCount_get(swigCPtr);
      return ret;
    } 
  }

  public BWAPIC_Event events {
    set {
      bwapiclientPINVOKE.GameData_events_set(swigCPtr, BWAPIC_Event.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_events_get(swigCPtr);
      BWAPIC_Event ret = (cPtr == IntPtr.Zero) ? null : new BWAPIC_Event(cPtr, false);
      return ret;
    } 
  }

  public int stringCount {
    set {
      bwapiclientPINVOKE.GameData_stringCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_stringCount_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_256__char strings {
    set {
      bwapiclientPINVOKE.GameData_strings_set(swigCPtr, SWIGTYPE_p_a_256__char.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_strings_get(swigCPtr);
      SWIGTYPE_p_a_256__char ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_a_256__char(cPtr, false);
      return ret;
    } 
  }

  public int shapeCount {
    set {
      bwapiclientPINVOKE.GameData_shapeCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_shapeCount_get(swigCPtr);
      return ret;
    } 
  }

  public Shape shapes {
    set {
      bwapiclientPINVOKE.GameData_shapes_set(swigCPtr, Shape.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_shapes_get(swigCPtr);
      Shape ret = (cPtr == IntPtr.Zero) ? null : new Shape(cPtr, false);
      return ret;
    } 
  }

  public int commandCount {
    set {
      bwapiclientPINVOKE.GameData_commandCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_commandCount_get(swigCPtr);
      return ret;
    } 
  }

  public Command commands {
    set {
      bwapiclientPINVOKE.GameData_commands_set(swigCPtr, Command.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_commands_get(swigCPtr);
      Command ret = (cPtr == IntPtr.Zero) ? null : new Command(cPtr, false);
      return ret;
    } 
  }

  public int unitCommandCount {
    set {
      bwapiclientPINVOKE.GameData_unitCommandCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.GameData_unitCommandCount_get(swigCPtr);
      return ret;
    } 
  }

  public BWAPIC_UnitCommand unitCommands {
    set {
      bwapiclientPINVOKE.GameData_unitCommands_set(swigCPtr, BWAPIC_UnitCommand.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.GameData_unitCommands_get(swigCPtr);
      BWAPIC_UnitCommand ret = (cPtr == IntPtr.Zero) ? null : new BWAPIC_UnitCommand(cPtr, false);
      return ret;
    } 
  }

}

}
