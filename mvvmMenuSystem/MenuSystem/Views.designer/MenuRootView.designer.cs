// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace mvvmMenuSystem {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class MenuRootViewBase : uFrame.MVVM.Views.ViewBase {
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public uFrame.MVVM.Views.ViewBase _shieldEmpty;
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public uFrame.MVVM.Views.ViewBase _mainMenu;
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public uFrame.MVVM.Views.ViewBase _loadingTop;
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public uFrame.MVVM.Views.ViewBase _shieldTop;
        
        public override string DefaultIdentifier {
            get {
                return "MenuRoot";
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(MenuRootViewModel);
            }
        }
        
        public MenuRootViewModel MenuRoot {
            get {
                return (MenuRootViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as MenuRootViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
            var menurootview = ((MenuRootViewModel)model);
            menurootview.shieldEmpty = this._shieldEmpty == null ? null :  ViewService.FetchViewModel(this._shieldEmpty) as ShieldViewModel;
            menurootview.mainMenu = this._mainMenu == null ? null :  ViewService.FetchViewModel(this._mainMenu) as MainMenuViewModel;
            menurootview.loadingTop = this._loadingTop == null ? null :  ViewService.FetchViewModel(this._loadingTop) as PanelViewModel;
            menurootview.shieldTop = this._shieldTop == null ? null :  ViewService.FetchViewModel(this._shieldTop) as ShieldViewModel;
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.MenuRoot to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }
        
        public virtual void ExecuteLoadPanel(LoadPanelCommand command) {
            command.Sender = MenuRoot;
            MenuRoot.LoadPanel.OnNext(command);
        }
    }
}