// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Battle/BattleActionType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleActionType.proto</summary>
  public static partial class BattleActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Battle/BattleActionType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1QT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUFjdGlvblR5cGUucHJv",
            "dG8SFlBPR09Qcm90b3MuRGF0YS5CYXR0bGUq/AEKEEJhdHRsZUFjdGlvblR5",
            "cGUSEAoMQUNUSU9OX1VOU0VUEAASEQoNQUNUSU9OX0FUVEFDSxABEhAKDEFD",
            "VElPTl9ET0RHRRACEhkKFUFDVElPTl9TUEVDSUFMX0FUVEFDSxADEhcKE0FD",
            "VElPTl9TV0FQX1BPS0VNT04QBBIQCgxBQ1RJT05fRkFJTlQQBRIWChJBQ1RJ",
            "T05fUExBWUVSX0pPSU4QBhIWChJBQ1RJT05fUExBWUVSX1FVSVQQBxISCg5B",
            "Q1RJT05fVklDVE9SWRAIEhEKDUFDVElPTl9ERUZFQVQQCRIUChBBQ1RJT05f",
            "VElNRURfT1VUEApiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Data.Battle.BattleActionType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum BattleActionType {
    [pbr::OriginalName("ACTION_UNSET")] ActionUnset = 0,
    [pbr::OriginalName("ACTION_ATTACK")] ActionAttack = 1,
    [pbr::OriginalName("ACTION_DODGE")] ActionDodge = 2,
    [pbr::OriginalName("ACTION_SPECIAL_ATTACK")] ActionSpecialAttack = 3,
    [pbr::OriginalName("ACTION_SWAP_POKEMON")] ActionSwapPokemon = 4,
    [pbr::OriginalName("ACTION_FAINT")] ActionFaint = 5,
    [pbr::OriginalName("ACTION_PLAYER_JOIN")] ActionPlayerJoin = 6,
    [pbr::OriginalName("ACTION_PLAYER_QUIT")] ActionPlayerQuit = 7,
    [pbr::OriginalName("ACTION_VICTORY")] ActionVictory = 8,
    [pbr::OriginalName("ACTION_DEFEAT")] ActionDefeat = 9,
    [pbr::OriginalName("ACTION_TIMED_OUT")] ActionTimedOut = 10,
  }

  #endregion

}

#endregion Designer generated code
