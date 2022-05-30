import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// children components
import { InspectionComponent } from './modules/inspection/inspection.component';
import { BonyPalpationComponent } from './modules/bony-palpation/bony-palpation.component';
import { SoftTissuePalpationComponent } from './modules/soft-tissue-palpation/soft-tissue-palpation.component';
import { RangeOfMotionComponent } from './modules/range-of-motion/range-of-motion.component';
import { NeurologicExaminationComponent } from './modules/neurologic-examination/neurologic-examination.component';
import { SpecialTestsComponent } from './modules/special-tests/special-tests.component';
import { RelatedAreasComponent } from './modules/related-areas/related-areas.component';

const routs: Routes = [
  { path: '', children: [
      { path: 'inspection', component: InspectionComponent },
      { path: 'bony-palpation', component: BonyPalpationComponent },
      { path: 'soft-tissue-palpation', component: SoftTissuePalpationComponent },
      { path: 'range-of-motion', component: RangeOfMotionComponent },
      { path: 'neurologic-examination', component: NeurologicExaminationComponent },
      { path: 'special-tests', component: SpecialTestsComponent },
      { path: 'related-areas', component: RelatedAreasComponent }
    ]
  }
]

@NgModule({
  imports: [RouterModule.forChild(routs)],
  exports: [RouterModule]
})
export class ShoulderRoutingModule {
}
