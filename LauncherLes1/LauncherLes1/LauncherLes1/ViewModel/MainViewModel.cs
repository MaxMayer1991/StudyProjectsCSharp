using GalaSoft.MvvmLight.Command;
using LauncherLes1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace LauncherLes1.ViewModel
{
    internal class MainViewModel : ViewModedBase
    {
        private Page WF = new WF();
        private Page CL = new CL();
        private Page HK = new HK();
        private Page Hades = new Hades();
        private Page POE = new POE();
        private Page VL = new VL();
        private Page MGV = new MGV();
        private Page FC = new FC();
        private Page _CurPage = new WF();
        

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }
        public ICommand OpenCLPage
        {
            get
            {
                return new RelayCommand(() => CurPage = CL);
            }
        }
        public ICommand OpenWFPage
        {
            get
            {
                return new RelayCommand(() => CurPage = WF);
            }
        }
        public ICommand OpenHKPage
        {
            get
            {
                return new RelayCommand(() => CurPage = HK);
            }
        }
        public ICommand OpenHadesPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Hades);
            }
        }
        public ICommand OpenPOEPage
        {
            get
            {
                return new RelayCommand(() => CurPage = POE);
            }
        }
        public ICommand OpenVLPage
        {
            get
            {
                return new RelayCommand(() => CurPage = VL);
            }
        }
        public ICommand OpenMGVPage
        {
            get
            {
                return new RelayCommand(() => CurPage = MGV);
            }
        }
        public ICommand OpenFCPage
        {
            get
            {
                return new RelayCommand(() => CurPage = FC);
            }
        }
    }
}
