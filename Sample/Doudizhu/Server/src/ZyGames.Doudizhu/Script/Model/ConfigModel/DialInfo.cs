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
    /// 转盘奖励配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class DialInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public DialInfo()
            : base(true)
        {
            
        }      
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField(true)]
        public int ID{ get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField]
        public int GameCoin{ get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField]
        public string HeadID{ get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField]
        public decimal Probability{ get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField]
        public string ItemDesc{ get; set; }
    

	}
}