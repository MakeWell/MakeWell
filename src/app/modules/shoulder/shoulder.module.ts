import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShoulderComponent } from './shoulder.component';

// routing modules
import { ShoulderRoutingModule } from './shoulder-routing.module';


import {MatTreeModule} from '@angular/material/tree';

@NgModule({
  imports: [
    CommonModule,
    ShoulderRoutingModule,
    MatTreeModule,
  ],
  declarations: [ShoulderComponent]
})
export class ShoulderModule { }
