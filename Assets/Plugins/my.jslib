+mergeInto(LibraryManager.library, {

 GetLang : function (){
 var lang = ysdk.environment.i18n.lang;
 var bufferSize = lengthBytesUTF8(lang) + 1;
 var buffer = _malloc(bufferSize);
 stringToUTF8(lang, buffer, bufferSize);
 return buffer;
 },

 ShowAdv : function(){
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          // some action after close
        },
        onError: function(error) {
          // some action on error
        }
    }
})
 },
 AddLives : function(){

     ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
          myGameInstance.SendMessage("Adv","Reset", value);
        },
        onClose: () => {
          console.log('Video ad closed.');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
})
 },

 
});