﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 成就配置
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class AchievementInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public AchievementInfo()
            : base(true)
        {
            
        }   

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField(true)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField]
        public string Name{ get; set; }

        /// <summary>
        /// 成就类型
        /// </summary>        
        [ProtoMember(3)]
        [EntityField]
        public AchieveType Type{ get; set; }
   
        /// <summary>
        /// 成就达到值
        /// </summary>        
        [ProtoMember(4)]
        [EntityField]
        public int TargetNum{ get; set; }


        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField]
        public string HeadIcon{ get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField]
        public string Description{ get; set; }
    

	}
}