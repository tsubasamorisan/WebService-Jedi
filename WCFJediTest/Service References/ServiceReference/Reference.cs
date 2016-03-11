﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFJediTest.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getJedis", ReplyAction="http://tempuri.org/IService/getJedisResponse")]
        System.Collections.Generic.List<WCFJedi.JediWS> getJedis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getJedis", ReplyAction="http://tempuri.org/IService/getJedisResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.JediWS>> getJedisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getStades", ReplyAction="http://tempuri.org/IService/getStadesResponse")]
        System.Collections.Generic.List<WCFJedi.StadeWS> getStades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getStades", ReplyAction="http://tempuri.org/IService/getStadesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.StadeWS>> getStadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getMatches", ReplyAction="http://tempuri.org/IService/getMatchesResponse")]
        System.Collections.Generic.List<WCFJedi.MatchWS> getMatches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getMatches", ReplyAction="http://tempuri.org/IService/getMatchesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.MatchWS>> getMatchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTournois", ReplyAction="http://tempuri.org/IService/getTournoisResponse")]
        System.Collections.Generic.List<WCFJedi.TournoiWS> getTournois();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTournois", ReplyAction="http://tempuri.org/IService/getTournoisResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.TournoiWS>> getTournoisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCaracteristiquesOf", ReplyAction="http://tempuri.org/IService/getCaracteristiquesOfResponse")]
        System.Collections.Generic.List<WCFJedi.CaracteristiqueWS> getCaracteristiquesOf(string jediName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCaracteristiquesOf", ReplyAction="http://tempuri.org/IService/getCaracteristiquesOfResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.CaracteristiqueWS>> getCaracteristiquesOfAsync(string jediName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addJedi", ReplyAction="http://tempuri.org/IService/addJediResponse")]
        bool addJedi(WCFJedi.JediWS jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addJedi", ReplyAction="http://tempuri.org/IService/addJediResponse")]
        System.Threading.Tasks.Task<bool> addJediAsync(WCFJedi.JediWS jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addStade", ReplyAction="http://tempuri.org/IService/addStadeResponse")]
        bool addStade(WCFJedi.StadeWS stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addStade", ReplyAction="http://tempuri.org/IService/addStadeResponse")]
        System.Threading.Tasks.Task<bool> addStadeAsync(WCFJedi.StadeWS stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addMatch", ReplyAction="http://tempuri.org/IService/addMatchResponse")]
        bool addMatch(WCFJedi.MatchWS match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addMatch", ReplyAction="http://tempuri.org/IService/addMatchResponse")]
        System.Threading.Tasks.Task<bool> addMatchAsync(WCFJedi.MatchWS match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addTournoi", ReplyAction="http://tempuri.org/IService/addTournoiResponse")]
        bool addTournoi(WCFJedi.TournoiWS tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/addTournoi", ReplyAction="http://tempuri.org/IService/addTournoiResponse")]
        System.Threading.Tasks.Task<bool> addTournoiAsync(WCFJedi.TournoiWS tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateJedi", ReplyAction="http://tempuri.org/IService/updateJediResponse")]
        bool updateJedi(WCFJedi.JediWS jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateJedi", ReplyAction="http://tempuri.org/IService/updateJediResponse")]
        System.Threading.Tasks.Task<bool> updateJediAsync(WCFJedi.JediWS jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateStade", ReplyAction="http://tempuri.org/IService/updateStadeResponse")]
        bool updateStade(WCFJedi.StadeWS stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateStade", ReplyAction="http://tempuri.org/IService/updateStadeResponse")]
        System.Threading.Tasks.Task<bool> updateStadeAsync(WCFJedi.StadeWS stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateMatch", ReplyAction="http://tempuri.org/IService/updateMatchResponse")]
        bool updateMatch(WCFJedi.MatchWS match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateMatch", ReplyAction="http://tempuri.org/IService/updateMatchResponse")]
        System.Threading.Tasks.Task<bool> updateMatchAsync(WCFJedi.MatchWS match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateTournoi", ReplyAction="http://tempuri.org/IService/updateTournoiResponse")]
        bool updateTournoi(WCFJedi.TournoiWS tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateTournoi", ReplyAction="http://tempuri.org/IService/updateTournoiResponse")]
        System.Threading.Tasks.Task<bool> updateTournoiAsync(WCFJedi.TournoiWS tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeJedi", ReplyAction="http://tempuri.org/IService/removeJediResponse")]
        bool removeJedi(WCFJedi.JediWS jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeJedi", ReplyAction="http://tempuri.org/IService/removeJediResponse")]
        System.Threading.Tasks.Task<bool> removeJediAsync(WCFJedi.JediWS jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeStade", ReplyAction="http://tempuri.org/IService/removeStadeResponse")]
        bool removeStade(WCFJedi.StadeWS stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeStade", ReplyAction="http://tempuri.org/IService/removeStadeResponse")]
        System.Threading.Tasks.Task<bool> removeStadeAsync(WCFJedi.StadeWS stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeMatch", ReplyAction="http://tempuri.org/IService/removeMatchResponse")]
        bool removeMatch(WCFJedi.MatchWS match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeMatch", ReplyAction="http://tempuri.org/IService/removeMatchResponse")]
        System.Threading.Tasks.Task<bool> removeMatchAsync(WCFJedi.MatchWS match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeTournoi", ReplyAction="http://tempuri.org/IService/removeTournoiResponse")]
        bool removeTournoi(WCFJedi.TournoiWS tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeTournoi", ReplyAction="http://tempuri.org/IService/removeTournoiResponse")]
        System.Threading.Tasks.Task<bool> removeTournoiAsync(WCFJedi.TournoiWS tournoi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WCFJediTest.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WCFJediTest.ServiceReference.IService>, WCFJediTest.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WCFJedi.JediWS> getJedis() {
            return base.Channel.getJedis();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.JediWS>> getJedisAsync() {
            return base.Channel.getJedisAsync();
        }
        
        public System.Collections.Generic.List<WCFJedi.StadeWS> getStades() {
            return base.Channel.getStades();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.StadeWS>> getStadesAsync() {
            return base.Channel.getStadesAsync();
        }
        
        public System.Collections.Generic.List<WCFJedi.MatchWS> getMatches() {
            return base.Channel.getMatches();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.MatchWS>> getMatchesAsync() {
            return base.Channel.getMatchesAsync();
        }
        
        public System.Collections.Generic.List<WCFJedi.TournoiWS> getTournois() {
            return base.Channel.getTournois();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.TournoiWS>> getTournoisAsync() {
            return base.Channel.getTournoisAsync();
        }
        
        public System.Collections.Generic.List<WCFJedi.CaracteristiqueWS> getCaracteristiquesOf(string jediName) {
            return base.Channel.getCaracteristiquesOf(jediName);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WCFJedi.CaracteristiqueWS>> getCaracteristiquesOfAsync(string jediName) {
            return base.Channel.getCaracteristiquesOfAsync(jediName);
        }
        
        public bool addJedi(WCFJedi.JediWS jedi) {
            return base.Channel.addJedi(jedi);
        }
        
        public System.Threading.Tasks.Task<bool> addJediAsync(WCFJedi.JediWS jedi) {
            return base.Channel.addJediAsync(jedi);
        }
        
        public bool addStade(WCFJedi.StadeWS stade) {
            return base.Channel.addStade(stade);
        }
        
        public System.Threading.Tasks.Task<bool> addStadeAsync(WCFJedi.StadeWS stade) {
            return base.Channel.addStadeAsync(stade);
        }
        
        public bool addMatch(WCFJedi.MatchWS match) {
            return base.Channel.addMatch(match);
        }
        
        public System.Threading.Tasks.Task<bool> addMatchAsync(WCFJedi.MatchWS match) {
            return base.Channel.addMatchAsync(match);
        }
        
        public bool addTournoi(WCFJedi.TournoiWS tournoi) {
            return base.Channel.addTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task<bool> addTournoiAsync(WCFJedi.TournoiWS tournoi) {
            return base.Channel.addTournoiAsync(tournoi);
        }
        
        public bool updateJedi(WCFJedi.JediWS jedi) {
            return base.Channel.updateJedi(jedi);
        }
        
        public System.Threading.Tasks.Task<bool> updateJediAsync(WCFJedi.JediWS jedi) {
            return base.Channel.updateJediAsync(jedi);
        }
        
        public bool updateStade(WCFJedi.StadeWS stade) {
            return base.Channel.updateStade(stade);
        }
        
        public System.Threading.Tasks.Task<bool> updateStadeAsync(WCFJedi.StadeWS stade) {
            return base.Channel.updateStadeAsync(stade);
        }
        
        public bool updateMatch(WCFJedi.MatchWS match) {
            return base.Channel.updateMatch(match);
        }
        
        public System.Threading.Tasks.Task<bool> updateMatchAsync(WCFJedi.MatchWS match) {
            return base.Channel.updateMatchAsync(match);
        }
        
        public bool updateTournoi(WCFJedi.TournoiWS tournoi) {
            return base.Channel.updateTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task<bool> updateTournoiAsync(WCFJedi.TournoiWS tournoi) {
            return base.Channel.updateTournoiAsync(tournoi);
        }
        
        public bool removeJedi(WCFJedi.JediWS jedi) {
            return base.Channel.removeJedi(jedi);
        }
        
        public System.Threading.Tasks.Task<bool> removeJediAsync(WCFJedi.JediWS jedi) {
            return base.Channel.removeJediAsync(jedi);
        }
        
        public bool removeStade(WCFJedi.StadeWS stade) {
            return base.Channel.removeStade(stade);
        }
        
        public System.Threading.Tasks.Task<bool> removeStadeAsync(WCFJedi.StadeWS stade) {
            return base.Channel.removeStadeAsync(stade);
        }
        
        public bool removeMatch(WCFJedi.MatchWS match) {
            return base.Channel.removeMatch(match);
        }
        
        public System.Threading.Tasks.Task<bool> removeMatchAsync(WCFJedi.MatchWS match) {
            return base.Channel.removeMatchAsync(match);
        }
        
        public bool removeTournoi(WCFJedi.TournoiWS tournoi) {
            return base.Channel.removeTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task<bool> removeTournoiAsync(WCFJedi.TournoiWS tournoi) {
            return base.Channel.removeTournoiAsync(tournoi);
        }
    }
}
