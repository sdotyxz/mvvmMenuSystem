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
    using mvvmMenuSystem;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public partial class PanelViewModelBase : uFrame.MVVM.ViewModels.ViewModel {
        
        private P<Single> _depthIndexProperty;
        
        private P<String> _panelNameProperty;
        
        private P<Boolean> _isCacheProperty;
        
        private P<BGM> _BGMTypeProperty;
        
        private P<String> _CurrentBGMProperty;
        
        private P<Boolean> _isActiveProperty;
        
        private P<String> _BGMNameProperty;
        
        private P<Int32> _posIndexProperty;
        
        private Signal<FocusPanelCommand> _FocusPanel;
        
        private Signal<HidePanelCommand> _HidePanel;
        
        private Signal<ShowPanelCommand> _ShowPanel;
        
        private Signal<SetPanelDataCommand> _SetPanelData;
        
        private Signal<PlayPanelAnimationCommand> _PlayPanelAnimation;
        
        private Signal<DestroyPanelCommand> _DestroyPanel;
        
        public PanelViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<Single> depthIndexProperty {
            get {
                return _depthIndexProperty;
            }
            set {
                _depthIndexProperty = value;
            }
        }
        
        public virtual P<String> panelNameProperty {
            get {
                return _panelNameProperty;
            }
            set {
                _panelNameProperty = value;
            }
        }
        
        public virtual P<Boolean> isCacheProperty {
            get {
                return _isCacheProperty;
            }
            set {
                _isCacheProperty = value;
            }
        }
        
        public virtual P<BGM> BGMTypeProperty {
            get {
                return _BGMTypeProperty;
            }
            set {
                _BGMTypeProperty = value;
            }
        }
        
        public virtual P<String> CurrentBGMProperty {
            get {
                return _CurrentBGMProperty;
            }
            set {
                _CurrentBGMProperty = value;
            }
        }
        
        public virtual P<Boolean> isActiveProperty {
            get {
                return _isActiveProperty;
            }
            set {
                _isActiveProperty = value;
            }
        }
        
        public virtual P<String> BGMNameProperty {
            get {
                return _BGMNameProperty;
            }
            set {
                _BGMNameProperty = value;
            }
        }
        
        public virtual P<Int32> posIndexProperty {
            get {
                return _posIndexProperty;
            }
            set {
                _posIndexProperty = value;
            }
        }
        
        public virtual Single depthIndex {
            get {
                return depthIndexProperty.Value;
            }
            set {
                depthIndexProperty.Value = value;
            }
        }
        
        public virtual String panelName {
            get {
                return panelNameProperty.Value;
            }
            set {
                panelNameProperty.Value = value;
            }
        }
        
        public virtual Boolean isCache {
            get {
                return isCacheProperty.Value;
            }
            set {
                isCacheProperty.Value = value;
            }
        }
        
        public virtual BGM BGMType {
            get {
                return BGMTypeProperty.Value;
            }
            set {
                BGMTypeProperty.Value = value;
            }
        }
        
        public virtual String CurrentBGM {
            get {
                return CurrentBGMProperty.Value;
            }
            set {
                CurrentBGMProperty.Value = value;
            }
        }
        
        public virtual Boolean isActive {
            get {
                return isActiveProperty.Value;
            }
            set {
                isActiveProperty.Value = value;
            }
        }
        
        public virtual String BGMName {
            get {
                return BGMNameProperty.Value;
            }
            set {
                BGMNameProperty.Value = value;
            }
        }
        
        public virtual Int32 posIndex {
            get {
                return posIndexProperty.Value;
            }
            set {
                posIndexProperty.Value = value;
            }
        }
        
        public virtual Signal<FocusPanelCommand> FocusPanel {
            get {
                return _FocusPanel;
            }
            set {
                _FocusPanel = value;
            }
        }
        
        public virtual Signal<HidePanelCommand> HidePanel {
            get {
                return _HidePanel;
            }
            set {
                _HidePanel = value;
            }
        }
        
        public virtual Signal<ShowPanelCommand> ShowPanel {
            get {
                return _ShowPanel;
            }
            set {
                _ShowPanel = value;
            }
        }
        
        public virtual Signal<SetPanelDataCommand> SetPanelData {
            get {
                return _SetPanelData;
            }
            set {
                _SetPanelData = value;
            }
        }
        
        public virtual Signal<PlayPanelAnimationCommand> PlayPanelAnimation {
            get {
                return _PlayPanelAnimation;
            }
            set {
                _PlayPanelAnimation = value;
            }
        }
        
        public virtual Signal<DestroyPanelCommand> DestroyPanel {
            get {
                return _DestroyPanel;
            }
            set {
                _DestroyPanel = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            this.FocusPanel = new Signal<FocusPanelCommand>(this);
            this.HidePanel = new Signal<HidePanelCommand>(this);
            this.ShowPanel = new Signal<ShowPanelCommand>(this);
            this.SetPanelData = new Signal<SetPanelDataCommand>(this);
            this.PlayPanelAnimation = new Signal<PlayPanelAnimationCommand>(this);
            this.DestroyPanel = new Signal<DestroyPanelCommand>(this);
            _depthIndexProperty = new P<Single>(this, "depthIndex");
            _panelNameProperty = new P<String>(this, "panelName");
            _isCacheProperty = new P<Boolean>(this, "isCache");
            _BGMTypeProperty = new P<BGM>(this, "BGMType");
            _CurrentBGMProperty = new P<String>(this, "CurrentBGM");
            _isActiveProperty = new P<Boolean>(this, "isActive");
            _BGMNameProperty = new P<String>(this, "BGMName");
            _posIndexProperty = new P<Int32>(this, "posIndex");
        }
        
        public virtual void ExecuteHidePanel() {
            this.HidePanel.OnNext(new HidePanelCommand());
        }
        
        public virtual void ExecuteShowPanel() {
            this.ShowPanel.OnNext(new ShowPanelCommand());
        }
        
        public virtual void ExecuteDestroyPanel() {
            this.DestroyPanel.OnNext(new DestroyPanelCommand());
        }
        
        public virtual void Execute(FocusPanelCommand argument) {
            this.FocusPanel.OnNext(argument);
        }
        
        public virtual void Execute(SetPanelDataCommand argument) {
            this.SetPanelData.OnNext(argument);
        }
        
        public virtual void Execute(PlayPanelAnimationCommand argument) {
            this.PlayPanelAnimation.OnNext(argument);
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            this.depthIndex = stream.DeserializeFloat("depthIndex");;
            this.panelName = stream.DeserializeString("panelName");;
            this.isCache = stream.DeserializeBool("isCache");;
            this.BGMType = (BGM)stream.DeserializeInt("BGMType");;
            this.CurrentBGM = stream.DeserializeString("CurrentBGM");;
            this.isActive = stream.DeserializeBool("isActive");;
            this.BGMName = stream.DeserializeString("BGMName");;
            this.posIndex = stream.DeserializeInt("posIndex");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeFloat("depthIndex", this.depthIndex);
            stream.SerializeString("panelName", this.panelName);
            stream.SerializeBool("isCache", this.isCache);
            stream.SerializeInt("BGMType", (int)this.BGMType);;
            stream.SerializeString("CurrentBGM", this.CurrentBGM);
            stream.SerializeBool("isActive", this.isActive);
            stream.SerializeString("BGMName", this.BGMName);
            stream.SerializeInt("posIndex", this.posIndex);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
            list.Add(new ViewModelCommandInfo("FocusPanel", FocusPanel) { ParameterType = typeof(FocusPanelCommand) });
            list.Add(new ViewModelCommandInfo("HidePanel", HidePanel) { ParameterType = typeof(void) });
            list.Add(new ViewModelCommandInfo("ShowPanel", ShowPanel) { ParameterType = typeof(void) });
            list.Add(new ViewModelCommandInfo("SetPanelData", SetPanelData) { ParameterType = typeof(SetPanelDataCommand) });
            list.Add(new ViewModelCommandInfo("PlayPanelAnimation", PlayPanelAnimation) { ParameterType = typeof(PlayPanelAnimationCommand) });
            list.Add(new ViewModelCommandInfo("DestroyPanel", DestroyPanel) { ParameterType = typeof(void) });
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_depthIndexProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_panelNameProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_isCacheProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_BGMTypeProperty, false, false, true, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_CurrentBGMProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_isActiveProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_BGMNameProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_posIndexProperty, false, false, false, false));
        }
    }
    
    public partial class PanelViewModel {
        
        public PanelViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
