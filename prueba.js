const config = {
  apiKey: "AIzaSyDLhexv8NekHmaMXVskTLl6okeFlXjGnWE",
  authDomain: "invernadero-4af1e.firebaseapp.com",
  databaseURL: "https://invernadero-4af1e.firebaseio.com",
  storageBucket: "invernadero-4af1e.appspot.com",  
  };
 firebase.initializeApp(config);
 const preSensores = document.getElementById('Sensores');
 const dbref=firebase.database().ref().child('Sensores');
dbref.on('value', snap => {
preSensores.innerText =JSON.stringify(snap.val(), null, 3)
	});

   



