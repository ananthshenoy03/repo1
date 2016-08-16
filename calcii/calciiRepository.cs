﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace calcii
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the calciiRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
    [RepositoryFolder("a66239cc-2ed6-47bb-a534-b3cdf03520cd")]
    public partial class calciiRepository : RepoGenBaseFolder
    {
        static calciiRepository instance = new calciiRepository();
        calciiRepositoryFolders.CalculatorAppFolder _calculator;

        /// <summary>
        /// Gets the singleton class instance representing the calciiRepository element repository.
        /// </summary>
        [RepositoryFolder("a66239cc-2ed6-47bb-a534-b3cdf03520cd")]
        public static calciiRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public calciiRepository() 
            : base("calciiRepository", "/", null, 0, false, "a66239cc-2ed6-47bb-a534-b3cdf03520cd", ".\\RepositoryImages\\calciiRepositorya66239cc.rximgres")
        {
            _calculator = new calciiRepositoryFolders.CalculatorAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a66239cc-2ed6-47bb-a534-b3cdf03520cd")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Calculator folder.
        /// </summary>
        [RepositoryFolder("5e95523b-f019-474e-bc51-463954760fa5")]
        public virtual calciiRepositoryFolders.CalculatorAppFolder Calculator
        {
            get { return _calculator; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
    public partial class calciiRepositoryFolders
    {
        /// <summary>
        /// The CalculatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("5e95523b-f019-474e-bc51-463954760fa5")]
        public partial class CalculatorAppFolder : RepoGenBaseFolder
        {
            calciiRepositoryFolders.CalcFolder _calc;
            RepoItemInfo _closeInfo;

            /// <summary>
            /// Creates a new Calculator  folder.
            /// </summary>
            public CalculatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Calculator", "/form[@title='Calculator']", parentFolder, 30000, null, true, "5e95523b-f019-474e-bc51-463954760fa5", "")
            {
                _calc = new calciiRepositoryFolders.CalcFolder(this);
                _closeInfo = new RepoItemInfo(this, "Close", "?/?/button[@accessiblename='Close']", 30000, null, "d8dbfbc3-7bcd-47a5-a65c-651b6fe991b9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5e95523b-f019-474e-bc51-463954760fa5")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5e95523b-f019-474e-bc51-463954760fa5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("d8dbfbc3-7bcd-47a5-a65c-651b6fe991b9")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("d8dbfbc3-7bcd-47a5-a65c-651b6fe991b9")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }

            /// <summary>
            /// The Calc folder.
            /// </summary>
            [RepositoryFolder("4d093410-2cd9-4984-8125-8bccaa66acee")]
            public virtual calciiRepositoryFolders.CalcFolder Calc
            {
                get { return _calc; }
            }
        }

        /// <summary>
        /// The CalcFolder folder.
        /// </summary>
        [RepositoryFolder("4d093410-2cd9-4984-8125-8bccaa66acee")]
        public partial class CalcFolder : RepoGenBaseFolder
        {
            RepoItemInfo _button3Info;
            RepoItemInfo _buttonInfo;
            RepoItemInfo _button2Info;
            RepoItemInfo _button1Info;

            /// <summary>
            /// Creates a new Calc  folder.
            /// </summary>
            public CalcFolder(RepoGenBaseFolder parentFolder) :
                    base("Calc", "?/?/container[@instance='1']", parentFolder, 30000, null, false, "4d093410-2cd9-4984-8125-8bccaa66acee", "")
            {
                _button3Info = new RepoItemInfo(this, "Button3", "button[@controlid='121']", 30000, null, "b4fd0be4-d633-4b63-af93-c940dd6d11e9");
                _buttonInfo = new RepoItemInfo(this, "Button", "button[@controlid='134']", 30000, null, "fff0b833-1daa-4d64-b702-48bcbc097594");
                _button2Info = new RepoItemInfo(this, "Button2", "button[@controlid='135']", 30000, null, "87123c0f-8668-4129-8756-3aab406a9daa");
                _button1Info = new RepoItemInfo(this, "Button1", "button[@controlid='92']", 30000, null, "39cac17f-84a6-45fd-8a09-7296676724a8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4d093410-2cd9-4984-8125-8bccaa66acee")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4d093410-2cd9-4984-8125-8bccaa66acee")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Button3 item.
            /// </summary>
            [RepositoryItem("b4fd0be4-d633-4b63-af93-c940dd6d11e9")]
            public virtual Ranorex.Button Button3
            {
                get
                {
                    return _button3Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button3 item info.
            /// </summary>
            [RepositoryItemInfo("b4fd0be4-d633-4b63-af93-c940dd6d11e9")]
            public virtual RepoItemInfo Button3Info
            {
                get
                {
                    return _button3Info;
                }
            }

            /// <summary>
            /// The Button item.
            /// </summary>
            [RepositoryItem("fff0b833-1daa-4d64-b702-48bcbc097594")]
            public virtual Ranorex.Button Button
            {
                get
                {
                    return _buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button item info.
            /// </summary>
            [RepositoryItemInfo("fff0b833-1daa-4d64-b702-48bcbc097594")]
            public virtual RepoItemInfo ButtonInfo
            {
                get
                {
                    return _buttonInfo;
                }
            }

            /// <summary>
            /// The Button2 item.
            /// </summary>
            [RepositoryItem("87123c0f-8668-4129-8756-3aab406a9daa")]
            public virtual Ranorex.Button Button2
            {
                get
                {
                    return _button2Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button2 item info.
            /// </summary>
            [RepositoryItemInfo("87123c0f-8668-4129-8756-3aab406a9daa")]
            public virtual RepoItemInfo Button2Info
            {
                get
                {
                    return _button2Info;
                }
            }

            /// <summary>
            /// The Button1 item.
            /// </summary>
            [RepositoryItem("39cac17f-84a6-45fd-8a09-7296676724a8")]
            public virtual Ranorex.Button Button1
            {
                get
                {
                    return _button1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button1 item info.
            /// </summary>
            [RepositoryItemInfo("39cac17f-84a6-45fd-8a09-7296676724a8")]
            public virtual RepoItemInfo Button1Info
            {
                get
                {
                    return _button1Info;
                }
            }
        }

    }
#pragma warning restore 0436
}