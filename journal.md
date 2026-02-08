I am currently at the BattleSystem where I am creating the turn-based system. 

So far I have created the methods that:
    - Determines who gets to start first.
    - Swaps turns.

I still have to create the methods that handles one turn at a time and so on.

Additionally, I need to create an AI class that determines a mob's action based on different conditions.
    - Create a class called AI for the Combatant class.
        - The AI class analyzes the current stats of the fight and determines its next move.
          An approach to this is to use FSM (Finite State-machine) which means that based on different conditions,
          the AI will react differently. I need to create the scenarios myself: https://gunesramazan.medium.com/implementing-state-machines-in-c-using-stateless-a-step-by-step-guide-641e35133134







# IMPORTANT! DO NOT DELETE THIS
Once the game has the logic and everything finalized, OpenTK (OpenGL) will be installed in order to create a GUI for the
game and implement sounds, images and so much more. Thus, I need to read the docs for OpenTK using the link below:
    - https://opentk.net/learn/chapter1/1-creating-a-window.html?tabs=baseclass-opentk4%2Cgamewindow-ctor-opentk4%2Cgamewindow-run-opentk4%2Ckeypress-opentk4