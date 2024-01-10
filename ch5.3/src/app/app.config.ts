import { APP_INITIALIZER, ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { APP_BASE_HREF } from '@angular/common';


import WebXPanel, {WebXPanelConfigParams, WebXPanelEvents, isActive}  from "@crestron/ch5-webxpanel"; 

const configuration: Partial<WebXPanelConfigParams> = { 
  // host: '', // defaults to window.location.host
   ipId: '0x03' // string representing a hex value. Might contain "0x" or not. Defaults to "0x03"
  // roomId: 'virtual_control_room_id', // defaults to empty string
}; 

const webXPanelFactory = () => () => {
  if (isActive) { 
    WebXPanel.initialize(configuration); 
  } 
} 


export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes), { provide: APP_BASE_HREF, useValue: './' }, { provide: APP_INITIALIZER, useFactory: webXPanelFactory, multi: true },]
};

