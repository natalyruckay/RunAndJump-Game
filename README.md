# RunAndJump-Game
Jednoduchá skákacia hra. 

Cieľom hry je preskákať pomocou medzerníka prekážky, ktoré prídu hráčovi do cesty. Hra sa končí práve vtedy, keď sa hráč dotkne prekážky. 
Prekážky postupne zrýchľujú. V ľavom hornom rohu sa počíta počet preskočených prekážok. Pre uľahčenie hry, ak sa hráč dotkne prekážky stačí 
stlačiť klávesu R a hra začne od začiatku. Na úvodnej obrazovke sa nachádza tlačidlo „Start Game“ a v skratke opísané pravidlá hry.

Opis kódu:

Form1.cs [návrh] obsahuje grafické zobrazenie hry. Vložila som zopár obrázkov .jpg a .gif. Majú transparentné pozadie.
Form1.cs obsahuje zdrojový kód. Na začiatku sú spomenuté všetky premenné, ktoré v kóde používam. 
Prvá metóda private void MainGameTimerEvent – zalinkované v gameTimer-i, obsahuje podmienky pre jumping a rozmiestnenie prekážok (obstacle1 a obstacle2).
Ďaľšie 2 metódy private void keyisdown a private void keyisup – slúžia na skákanie. Ak je/nie je stlačený medzerník.
Posledná private void GameReset – táto metóda vyresetuje všetky premenné, hráča a prekážky do pôvodného stavu. Znova spustí hru ak hráč stlačí R. 

Form2.cs [návrh] obsahuje grafické zobrazenie úvodnej strany. Hráč si tam vie prečítať pravidlá hry a kliknúť na Button – Start Game. 
Form2.cs slúži na to, aby keď sa klikne na Start Game zobrazí sa Form1.cs a začína sa hra. Na to slúži metóda private void button1_Click. Pri spustení hry sa 
okno Form2 zatvorí.

Posledné s čím som pracovala bol Program.cs. Tu sa pracuje s tým, ktoré okno sa pri Spustení otvorí. Application.Run(new Form2()); - ako prvé sa otvorí Form2. 

Podrobnosti jednotlivých metód aj premenných sú vysvetlené v zdrojovom kóde. 

Zdroje:
https://diiantedoespelho.blogspot.com/2021/05/animated-transparent-running-gif.html
https://thumbs.gfycat.com/HomelyKeenHydatidtapeworm-max-1mb.gif 
https://www.pngkit.com/png/detail/128-1286203_transparent-background-cloud-clipart.png
